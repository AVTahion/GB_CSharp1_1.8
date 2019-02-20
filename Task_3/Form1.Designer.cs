namespace Task_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddQuest = new System.Windows.Forms.Button();
            this.btnDelQuest = new System.Windows.Forms.Button();
            this.btnSaveQuest = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cBoxTrue = new System.Windows.Forms.CheckBox();
            this.tBoxQuestion = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(499, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator1,
            this.miExit});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 25);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(180, 26);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 26);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(180, 26);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(180, 26);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddQuest.Location = new System.Drawing.Point(13, 227);
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(93, 27);
            this.btnAddQuest.TabIndex = 1;
            this.btnAddQuest.Text = "Добавить";
            this.btnAddQuest.UseVisualStyleBackColor = true;
            this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
            // 
            // btnDelQuest
            // 
            this.btnDelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelQuest.Location = new System.Drawing.Point(112, 227);
            this.btnDelQuest.Name = "btnDelQuest";
            this.btnDelQuest.Size = new System.Drawing.Size(84, 27);
            this.btnDelQuest.TabIndex = 2;
            this.btnDelQuest.Text = "Удалить";
            this.btnDelQuest.UseVisualStyleBackColor = true;
            this.btnDelQuest.Click += new System.EventHandler(this.btnDelQuest_Click);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveQuest.Location = new System.Drawing.Point(203, 227);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(100, 27);
            this.btnSaveQuest.TabIndex = 3;
            this.btnSaveQuest.Text = "Сохранить";
            this.btnSaveQuest.UseVisualStyleBackColor = true;
            this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(320, 227);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(86, 20);
            this.nudNumber.TabIndex = 4;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // cBoxTrue
            // 
            this.cBoxTrue.AutoSize = true;
            this.cBoxTrue.Location = new System.Drawing.Point(412, 228);
            this.cBoxTrue.Name = "cBoxTrue";
            this.cBoxTrue.Size = new System.Drawing.Size(64, 17);
            this.cBoxTrue.TabIndex = 5;
            this.cBoxTrue.Text = "Правда";
            this.cBoxTrue.UseVisualStyleBackColor = true;
            this.cBoxTrue.CheckedChanged += new System.EventHandler(this.cBoxTrue_CheckedChanged);
            // 
            // tBoxQuestion
            // 
            this.tBoxQuestion.Location = new System.Drawing.Point(13, 28);
            this.tBoxQuestion.Multiline = true;
            this.tBoxQuestion.Name = "tBoxQuestion";
            this.tBoxQuestion.Size = new System.Drawing.Size(474, 193);
            this.tBoxQuestion.TabIndex = 6;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 25);
            this.toolStripButton1.Text = "О программе";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(180, 26);
            this.miSaveAs.Text = "Save as";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 266);
            this.Controls.Add(this.tBoxQuestion);
            this.Controls.Add(this.cBoxTrue);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.btnSaveQuest);
            this.Controls.Add(this.btnDelQuest);
            this.Controls.Add(this.btnAddQuest);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Редактор БД Верю-Не верю";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button btnAddQuest;
        private System.Windows.Forms.Button btnDelQuest;
        private System.Windows.Forms.Button btnSaveQuest;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox cBoxTrue;
        private System.Windows.Forms.TextBox tBoxQuestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
    }
}

