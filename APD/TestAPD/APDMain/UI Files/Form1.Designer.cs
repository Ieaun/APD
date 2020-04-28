namespace APDMain
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbMethods = new System.Windows.Forms.ListBox();
            this.lbStack = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDiffThread = new System.Windows.Forms.RadioButton();
            this.rbSameThread = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAwait = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbparam1 = new System.Windows.Forms.TextBox();
            this.tbparam2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbparam3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMethods
            // 
            this.lbMethods.FormattingEnabled = true;
            this.lbMethods.ItemHeight = 24;
            this.lbMethods.Location = new System.Drawing.Point(23, 44);
            this.lbMethods.Name = "lbMethods";
            this.lbMethods.Size = new System.Drawing.Size(491, 460);
            this.lbMethods.TabIndex = 0;
            // 
            // lbStack
            // 
            this.lbStack.FormattingEnabled = true;
            this.lbStack.ItemHeight = 24;
            this.lbStack.Location = new System.Drawing.Point(609, 44);
            this.lbStack.Name = "lbStack";
            this.lbStack.Size = new System.Drawing.Size(837, 460);
            this.lbStack.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 121);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to stack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Addtostack_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stack (FiFo)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Methods ";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(811, 510);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(288, 60);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute Stack";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_CLick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDiffThread);
            this.panel1.Controls.Add(this.rbSameThread);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 80);
            this.panel1.TabIndex = 6;
            // 
            // rbDiffThread
            // 
            this.rbDiffThread.AutoSize = true;
            this.rbDiffThread.Location = new System.Drawing.Point(26, 49);
            this.rbDiffThread.Name = "rbDiffThread";
            this.rbDiffThread.Size = new System.Drawing.Size(206, 29);
            this.rbDiffThread.TabIndex = 8;
            this.rbDiffThread.Text = "Start on new thread";
            this.rbDiffThread.UseVisualStyleBackColor = true;
            // 
            // rbSameThread
            // 
            this.rbSameThread.AutoSize = true;
            this.rbSameThread.Checked = true;
            this.rbSameThread.Location = new System.Drawing.Point(26, 16);
            this.rbSameThread.Name = "rbSameThread";
            this.rbSameThread.Size = new System.Drawing.Size(177, 29);
            this.rbSameThread.TabIndex = 7;
            this.rbSameThread.TabStop = true;
            this.rbSameThread.Text = "On same thread";
            this.rbSameThread.UseVisualStyleBackColor = true;
            this.rbSameThread.CheckedChanged += new System.EventHandler(this.rbSameThread_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(225, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread Select";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(609, 509);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(196, 122);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Clear Stack";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "-->";
            // 
            // cbAwait
            // 
            this.cbAwait.AutoSize = true;
            this.cbAwait.Checked = true;
            this.cbAwait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAwait.Location = new System.Drawing.Point(850, 587);
            this.cbAwait.Name = "cbAwait";
            this.cbAwait.Size = new System.Drawing.Size(203, 29);
            this.cbAwait.TabIndex = 10;
            this.cbAwait.Text = "Force thread await ";
            this.toolTip1.SetToolTip(this.cbAwait, resources.GetString("cbAwait.ToolTip"));
            this.cbAwait.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parameter 1";
            // 
            // tbparam1
            // 
            this.tbparam1.Location = new System.Drawing.Point(23, 662);
            this.tbparam1.Name = "tbparam1";
            this.tbparam1.Size = new System.Drawing.Size(142, 29);
            this.tbparam1.TabIndex = 12;
            // 
            // tbparam2
            // 
            this.tbparam2.Location = new System.Drawing.Point(183, 662);
            this.tbparam2.Name = "tbparam2";
            this.tbparam2.Size = new System.Drawing.Size(142, 29);
            this.tbparam2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parameter 2";
            // 
            // tbparam3
            // 
            this.tbparam3.Location = new System.Drawing.Point(350, 662);
            this.tbparam3.Name = "tbparam3";
            this.tbparam3.Size = new System.Drawing.Size(142, 29);
            this.tbparam3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parameter 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 711);
            this.Controls.Add(this.tbparam3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbparam2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbparam1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAwait);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbStack);
            this.Controls.Add(this.lbMethods);
            this.Name = "Form1";
            this.Text = "APD Actions ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMethods;
        private System.Windows.Forms.ListBox lbStack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDiffThread;
        private System.Windows.Forms.RadioButton rbSameThread;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAwait;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbparam1;
        private System.Windows.Forms.TextBox tbparam2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbparam3;
        private System.Windows.Forms.Label label6;
    }
}

