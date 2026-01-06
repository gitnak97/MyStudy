using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C_Sharp_Study._32강의
{
    public partial class StackDictionary : Form
    {
        // 컨트롤 타입별로 사이즈 스택 저장
        private readonly Dictionary<Type, Stack<CSize>> _sizesByType = new Dictionary<Type, Stack<CSize>>();

        public StackDictionary()
        {
            InitializeComponent();
        }

        private void StackDictionary_Load(object sender, EventArgs e)
        {
            LoadControlSizes();
        }

        private void LoadControlSizes()
        {
            _sizesByType.Clear();

            // 필요하면 여기만 늘리면 됨 (TextBox, ComboBox 등)
            _sizesByType[typeof(Button)] = CaptureSizes<Button>(groupBox1);
            _sizesByType[typeof(Label)] = CaptureSizes<Label>(groupBox1);
        }

        private static Stack<CSize> CaptureSizes<T>(Control parent) where T : Control
        {
            var stack = new Stack<CSize>();

            foreach (var ctrl in parent.Controls.OfType<T>())
            {
                stack.Push(new CSize
                {
                    Name = ctrl.Name,
                    Width = ctrl.Width,
                    Height = ctrl.Height
                });
            }

            return stack;
        }

        private void ControlSizeButton_Click(object sender, EventArgs e)
        {
            lboxResult.Items.Clear();

            PrintSizes<Button>("Button");
            PrintSizes<Label>("Label");
        }

        private void PrintSizes<T>(string displayName) where T : Control
        {
            Stack<CSize> stack;
            if (!_sizesByType.TryGetValue(typeof(T), out stack) || stack == null || stack.Count == 0)
            {
                lboxResult.Items.Add($"Control : {displayName}, (no items)");
                return;
            }

            foreach (var item in stack)
            {
                lboxResult.Items.Add(
                    string.Format("Control : {0}, Name : {1}, Size({2}, {3})",
                                  displayName, item.Name, item.Width, item.Height));
            }
        }
    }
}
