namespace Graphic
{
    partial class MyForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.RBpencil = new System.Windows.Forms.RadioButton();
            this.CBwidth = new System.Windows.Forms.ComboBox();
            this.RBeraser = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RBline = new System.Windows.Forms.RadioButton();
            this.RBellips = new System.Windows.Forms.RadioButton();
            this.RBrectangle = new System.Windows.Forms.RadioButton();
            this.RBtriangle = new System.Windows.Forms.RadioButton();
            this.RBsqtriangle = new System.Windows.Forms.RadioButton();
            this.RBfilling = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(81, 624);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(236, 54);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoad.Location = new System.Drawing.Point(370, 624);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(236, 54);
            this.ButtonLoad.TabIndex = 1;
            this.ButtonLoad.Text = "Загрузить";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.Location = new System.Drawing.Point(659, 624);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(236, 54);
            this.ButtonCreate.TabIndex = 2;
            this.ButtonCreate.Text = "Создать";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(1071, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(242, 92);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Инструменты для рисования";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RBpencil
            // 
            this.RBpencil.AutoSize = true;
            this.RBpencil.Checked = true;
            this.RBpencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBpencil.Location = new System.Drawing.Point(1077, 103);
            this.RBpencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBpencil.Name = "RBpencil";
            this.RBpencil.Size = new System.Drawing.Size(125, 29);
            this.RBpencil.TabIndex = 4;
            this.RBpencil.TabStop = true;
            this.RBpencil.Text = "Карандаш";
            this.RBpencil.UseVisualStyleBackColor = true;
            this.RBpencil.Click += new System.EventHandler(this.RBpencil_Click);
            // 
            // CBwidth
            // 
            this.CBwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBwidth.Items.AddRange(new object[] {
            "Толщина 1",
            "Толщина 2",
            "Толщина 3",
            "Толщина 4"});
            this.CBwidth.Location = new System.Drawing.Point(1101, 144);
            this.CBwidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBwidth.MaxDropDownItems = 4;
            this.CBwidth.Name = "CBwidth";
            this.CBwidth.Size = new System.Drawing.Size(189, 30);
            this.CBwidth.TabIndex = 5;
            this.CBwidth.SelectedIndexChanged += new System.EventHandler(this.CBwidth_SelectedIndexChanged);
            // 
            // RBeraser
            // 
            this.RBeraser.AutoSize = true;
            this.RBeraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBeraser.Location = new System.Drawing.Point(1077, 213);
            this.RBeraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBeraser.Name = "RBeraser";
            this.RBeraser.Size = new System.Drawing.Size(101, 29);
            this.RBeraser.TabIndex = 6;
            this.RBeraser.Text = "Ластик";
            this.RBeraser.UseVisualStyleBackColor = true;
            this.RBeraser.Click += new System.EventHandler(this.RBeraser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1136, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фигуры";
            // 
            // RBline
            // 
            this.RBline.AutoSize = true;
            this.RBline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBline.Location = new System.Drawing.Point(989, 325);
            this.RBline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBline.Name = "RBline";
            this.RBline.Size = new System.Drawing.Size(92, 29);
            this.RBline.TabIndex = 8;
            this.RBline.TabStop = true;
            this.RBline.Text = "Линия";
            this.RBline.UseVisualStyleBackColor = true;
            this.RBline.Click += new System.EventHandler(this.RBline_Click);
            // 
            // RBellips
            // 
            this.RBellips.AutoSize = true;
            this.RBellips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBellips.Location = new System.Drawing.Point(989, 373);
            this.RBellips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBellips.Name = "RBellips";
            this.RBellips.Size = new System.Drawing.Size(103, 29);
            this.RBellips.TabIndex = 9;
            this.RBellips.TabStop = true;
            this.RBellips.Text = "Эллипс";
            this.RBellips.UseVisualStyleBackColor = true;
            this.RBellips.Click += new System.EventHandler(this.RBellips_Click);
            // 
            // RBrectangle
            // 
            this.RBrectangle.AutoSize = true;
            this.RBrectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBrectangle.Location = new System.Drawing.Point(989, 418);
            this.RBrectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBrectangle.Name = "RBrectangle";
            this.RBrectangle.Size = new System.Drawing.Size(179, 29);
            this.RBrectangle.TabIndex = 10;
            this.RBrectangle.TabStop = true;
            this.RBrectangle.Text = "Прямоугольник";
            this.RBrectangle.UseVisualStyleBackColor = true;
            this.RBrectangle.Click += new System.EventHandler(this.RBrectangle_Click);
            // 
            // RBtriangle
            // 
            this.RBtriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBtriangle.Location = new System.Drawing.Point(1205, 307);
            this.RBtriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBtriangle.Name = "RBtriangle";
            this.RBtriangle.Size = new System.Drawing.Size(205, 62);
            this.RBtriangle.TabIndex = 11;
            this.RBtriangle.TabStop = true;
            this.RBtriangle.Text = "Произвольный треугольник";
            this.RBtriangle.UseVisualStyleBackColor = true;
            this.RBtriangle.Click += new System.EventHandler(this.RBtriangle_Click);
            // 
            // RBsqtriangle
            // 
            this.RBsqtriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBsqtriangle.Location = new System.Drawing.Point(1205, 392);
            this.RBsqtriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBsqtriangle.Name = "RBsqtriangle";
            this.RBsqtriangle.Size = new System.Drawing.Size(205, 62);
            this.RBsqtriangle.TabIndex = 12;
            this.RBsqtriangle.TabStop = true;
            this.RBsqtriangle.Text = "Прямоугольный треугольник";
            this.RBsqtriangle.UseVisualStyleBackColor = true;
            this.RBsqtriangle.Click += new System.EventHandler(this.RBsqtriangle_Click);
            // 
            // RBfilling
            // 
            this.RBfilling.AutoSize = true;
            this.RBfilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBfilling.Location = new System.Drawing.Point(1219, 213);
            this.RBfilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBfilling.Name = "RBfilling";
            this.RBfilling.Size = new System.Drawing.Size(109, 29);
            this.RBfilling.TabIndex = 13;
            this.RBfilling.TabStop = true;
            this.RBfilling.Text = "Заливка";
            this.RBfilling.UseVisualStyleBackColor = true;
            this.RBfilling.Click += new System.EventHandler(this.RBfilling_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1136, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Палитра";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(22, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 598);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1406, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RBfilling);
            this.Controls.Add(this.RBsqtriangle);
            this.Controls.Add(this.RBtriangle);
            this.Controls.Add(this.RBrectangle);
            this.Controls.Add(this.RBellips);
            this.Controls.Add(this.RBline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBeraser);
            this.Controls.Add(this.CBwidth);
            this.Controls.Add(this.RBpencil);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1424, 729);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1424, 729);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton RBpencil;
        private System.Windows.Forms.RadioButton RBeraser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBline;
        private System.Windows.Forms.RadioButton RBellips;
        private System.Windows.Forms.RadioButton RBrectangle;
        private System.Windows.Forms.RadioButton RBtriangle;
        private System.Windows.Forms.RadioButton RBsqtriangle;
        private System.Windows.Forms.RadioButton RBfilling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox CBwidth;
    }
}

