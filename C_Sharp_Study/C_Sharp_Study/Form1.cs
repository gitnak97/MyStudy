using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private Form _currentForm = null;

        private void OpenInRightPanel(Form form)
        {
            // 이전 화면 닫기
            _currentForm?.Close();
            _currentForm?.Dispose();
            _currentForm = form;

            splitContainer1.Panel2.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
        }



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            if (e.Node.Tag is Type)
            {
                Type formType = (Type)e.Node.Tag;

                // Form 타입만 열기
                if (typeof(Form).IsAssignableFrom(formType))
                {
                    Form form = (Form)Activator.CreateInstance(formType);
                    OpenInRightPanel(form);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            var forms = GetType().Assembly.GetTypes()
                .Where(t =>
                    typeof(Form).IsAssignableFrom(t) &&
                    !t.IsAbstract &&
                    t != typeof(Form1) &&
                    t.Namespace != null
                );

            // 네임스페이스 마지막 토큰 (Lecture33 등)으로 그룹화
            var groups = forms.GroupBy(t => t.Namespace.Split('.').Last());

            foreach (var grp in groups.OrderBy(g => g.Key))
            {
                TreeNode folderNode = new TreeNode(grp.Key); // ← 33강의, 34강의

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

        // 노드 생성 헬퍼
        private TreeNode NewNode(string text, Type formType)
        {
            TreeNode node = new TreeNode(text);
            node.Tag = formType;   // ★ 핵심
            return node;
        }
    }
}
