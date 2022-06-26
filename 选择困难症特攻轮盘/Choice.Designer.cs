
namespace 选择困难症特攻轮盘
{
    partial class Choice
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
            this.Choices = new System.Windows.Forms.RichTextBox();
            this.Choose = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Maintheme = new System.Windows.Forms.TextBox();
            this.Counts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Choices
            // 
            this.Choices.Location = new System.Drawing.Point(373, 61);
            this.Choices.Name = "Choices";
            this.Choices.Size = new System.Drawing.Size(235, 175);
            this.Choices.TabIndex = 0;
            this.Choices.Text = "冰淇淋\n蛋糕\n可乐";
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(373, 300);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(101, 38);
            this.Choose.TabIndex = 1;
            this.Choose.Text = "开始";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.Location = new System.Drawing.Point(38, 22);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(279, 291);
            this.Result.TabIndex = 2;
            this.Result.Text = "这里是结果";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(507, 300);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(101, 38);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "重置";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Maintheme
            // 
            this.Maintheme.Location = new System.Drawing.Point(373, 22);
            this.Maintheme.Name = "Maintheme";
            this.Maintheme.Size = new System.Drawing.Size(235, 25);
            this.Maintheme.TabIndex = 4;
            this.Maintheme.Text = "今天吃什么？";
            // 
            // Counts
            // 
            this.Counts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Counts.FormattingEnabled = true;
            this.Counts.Items.AddRange(new object[] {
            "1次定胜负！",
            "我很纠结所以要3次！",
            "5次取平均值减小误差！",
            "选择困难症晚期，10次谢谢"});
            this.Counts.Location = new System.Drawing.Point(373, 254);
            this.Counts.Name = "Counts";
            this.Counts.Size = new System.Drawing.Size(235, 23);
            this.Counts.TabIndex = 5;
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 363);
            this.Controls.Add(this.Counts);
            this.Controls.Add(this.Maintheme);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Choices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Choice";
            this.Text = "选择困难症专用选择器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Choices;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Maintheme;
        private System.Windows.Forms.ComboBox Counts;
    }
}

