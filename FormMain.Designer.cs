namespace Деревья_2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tBResult = new System.Windows.Forms.TextBox();
            this.lbllevelUnder = new System.Windows.Forms.Label();
            this.tBLevelK = new System.Windows.Forms.TextBox();
            this.nUDNumberTreeElements = new System.Windows.Forms.NumericUpDown();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCreateTree = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumberTreeElements)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(628, 13);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 19;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(815, 19);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "Result";
            // 
            // tBResult
            // 
            this.tBResult.Location = new System.Drawing.Point(709, 13);
            this.tBResult.Name = "tBResult";
            this.tBResult.Size = new System.Drawing.Size(100, 20);
            this.tBResult.TabIndex = 17;
            // 
            // lbllevelUnder
            // 
            this.lbllevelUnder.AutoSize = true;
            this.lbllevelUnder.Location = new System.Drawing.Point(282, 17);
            this.lbllevelUnder.Name = "lbllevelUnder";
            this.lbllevelUnder.Size = new System.Drawing.Size(43, 13);
            this.lbllevelUnder.TabIndex = 14;
            this.lbllevelUnder.Text = "Level K";
            // 
            // tBLevelK
            // 
            this.tBLevelK.Location = new System.Drawing.Point(176, 15);
            this.tBLevelK.Name = "tBLevelK";
            this.tBLevelK.Size = new System.Drawing.Size(100, 20);
            this.tBLevelK.TabIndex = 13;
            // 
            // nUDNumberTreeElements
            // 
            this.nUDNumberTreeElements.Location = new System.Drawing.Point(2, 12);
            this.nUDNumberTreeElements.Name = "nUDNumberTreeElements";
            this.nUDNumberTreeElements.Size = new System.Drawing.Size(44, 20);
            this.nUDNumberTreeElements.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(2, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(895, 325);
            this.panel.TabIndex = 11;
            // 
            // btnCreateTree
            // 
            this.btnCreateTree.Location = new System.Drawing.Point(52, 12);
            this.btnCreateTree.Name = "btnCreateTree";
            this.btnCreateTree.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTree.TabIndex = 10;
            this.btnCreateTree.Text = "Create";
            this.btnCreateTree.UseVisualStyleBackColor = true;
            this.btnCreateTree.Click += new System.EventHandler(this.btnCreateTree_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 378);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tBResult);
            this.Controls.Add(this.lbllevelUnder);
            this.Controls.Add(this.tBLevelK);
            this.Controls.Add(this.nUDNumberTreeElements);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCreateTree);
            this.Name = "FormMain";
            this.Text = "Task18.25";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumberTreeElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tBResult;
        private System.Windows.Forms.Label lbllevelUnder;
        private System.Windows.Forms.TextBox tBLevelK;
        private System.Windows.Forms.NumericUpDown nUDNumberTreeElements;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCreateTree;
    }
}

