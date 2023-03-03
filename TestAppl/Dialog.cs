using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppl
{
    public class InputDialog : Form
    {
        private Label _label;
        private TextBox _textBox;
        private Button _okButton;
        private Button _cancelButton;

        public string InputText { get { return _textBox.Text; } }

        public InputDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this._label = new System.Windows.Forms.Label();
            this._textBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _label
            // 
            this._label.Location = new System.Drawing.Point(10, 10);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(250, 20);
            this._label.TabIndex = 0;
            this._label.Text = "Enter a name for this stopwatch time:";
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(10, 40);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(250, 23);
            this._textBox.TabIndex = 1;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(10, 70);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "OK";
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(90, 70);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 3;
            this._cancelButton.Text = "Cancel";
            // 
            // InputDialog
            // 
            this.AcceptButton = this._okButton;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(280, 96);
            this.Controls.Add(this._label);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter a name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
