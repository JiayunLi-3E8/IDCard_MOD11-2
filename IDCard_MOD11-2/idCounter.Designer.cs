namespace IDCard_MOD11_2
{
    partial class idCounter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(idCounter));
            this.idNum_first17 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idNum_first17
            // 
            this.idNum_first17.Location = new System.Drawing.Point(119, 12);
            this.idNum_first17.MaxLength = 17;
            this.idNum_first17.Name = "idNum_first17";
            this.idNum_first17.Size = new System.Drawing.Size(186, 21);
            this.idNum_first17.TabIndex = 0;
            this.idNum_first17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idNum_first17.TextChanged += new System.EventHandler(this.IdNum_first17_TextChanged);
            this.idNum_first17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "身份证号(前17位)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份证号";
            // 
            // idNum
            // 
            this.idNum.Location = new System.Drawing.Point(119, 39);
            this.idNum.MaxLength = 18;
            this.idNum.Name = "idNum";
            this.idNum.ReadOnly = true;
            this.idNum.Size = new System.Drawing.Size(186, 21);
            this.idNum.TabIndex = 1;
            this.idNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idCounter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(321, 71);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idNum);
            this.Controls.Add(this.idNum_first17);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 110);
            this.MinimumSize = new System.Drawing.Size(337, 110);
            this.Name = "idCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "身份证号计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idNum_first17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idNum;
    }
}

