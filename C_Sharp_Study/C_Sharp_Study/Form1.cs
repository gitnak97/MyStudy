using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C_Sharp_Study
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<Type, Form> _cache = new Dictionary<Type, Form>();
        private Form _current = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            var forms = GetType().Assembly.GetTypes()               // 프로젝트 내 컴파일된 모든 클래스 타입 목록을 가져옴
                .Where(t =>
                    typeof(Form).IsAssignableFrom(t) &&                 // Form이거나 Form을 상속한 클래스만
                    !t.IsAbstract &&                                    // 추상 클래스 제외
                    t != typeof(Form1) &&                               // FORM1 제외
                    t.Namespace != null &&                              // 네임스페이스 없으면 제외
                    t.GetConstructor(Type.EmptyTypes) != null           // new() 가능한 것만
                );

            var groups = forms.GroupBy(t => t.Namespace.Split('.').Last())
                              .OrderBy(g => g.Key);

            foreach (var grp in groups)
            {
                TreeNode folderNode = new TreeNode(grp.Key);

                foreach (var formType in grp.OrderBy(t => t.Name))
                {
                    TreeNode node = new TreeNode(formType.Name);
                    node.Tag = formType;
                    folderNode.Nodes.Add(node);
                }

                treeView1.Nodes.Add(folderNode);
            }

            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var formType = e.Node == null ? null : e.Node.Tag as Type;
            if (formType == null) return;

            OpenInRightPanelCached(formType);
        }

        private void OpenInRightPanelCached(Type formType)
        {
            if (!typeof(Form).IsAssignableFrom(formType)) return;

            Form form;
            if (!_cache.TryGetValue(formType, out form) || form == null || form.IsDisposed)
            {
                form = (Form)Activator.CreateInstance(formType);

                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.WindowState = FormWindowState.Maximized;
                form.Dock = DockStyle.Fill;

                _cache[formType] = form;
                splitContainer1.Panel2.Controls.Add(form); // ★ add는 최초 1번만
            }

            if (_current != null && _current != form)
                _current.Hide();

            _current = form;
            form.Show();
            form.BringToFront();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (var f in _cache.Values)
            {
                if (f != null && !f.IsDisposed) f.Dispose();
            }
            _cache.Clear();

            base.OnFormClosed(e);
        }
    }
}
