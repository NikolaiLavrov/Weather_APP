namespace WeatherApp.View
{
    partial class FormWeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeatherApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnterCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.radioButtonKelvin = new System.Windows.Forms.RadioButton();
            this.btnLocation = new System.Windows.Forms.Button();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.btnToday = new System.Windows.Forms.Button();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.Label();
            this.txtCityDay = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.exitToolStripMenuItem.Text = "Закрыть";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lblEnterCity
            // 
            this.lblEnterCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnterCity.AutoEllipsis = true;
            this.lblEnterCity.AutoSize = true;
            this.lblEnterCity.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblEnterCity.Location = new System.Drawing.Point(9, 20);
            this.lblEnterCity.Name = "lblEnterCity";
            this.lblEnterCity.Size = new System.Drawing.Size(142, 19);
            this.lblEnterCity.TabIndex = 6;
            this.lblEnterCity.Text = "Выберите город:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 8;
            this.label1.Visible = false;
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTomorrow.AutoEllipsis = true;
            this.btnTomorrow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTomorrow.Location = new System.Drawing.Point(198, 110);
            this.btnTomorrow.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(140, 40);
            this.btnTomorrow.TabIndex = 1;
            this.btnTomorrow.TabStop = false;
            this.btnTomorrow.Text = "Завтра";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.BtnTomorrowWeather_Click);
            // 
            // radioButtonKelvin
            // 
            this.radioButtonKelvin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonKelvin.AutoSize = true;
            this.radioButtonKelvin.Location = new System.Drawing.Point(387, 121);
            this.radioButtonKelvin.Name = "radioButtonKelvin";
            this.radioButtonKelvin.Size = new System.Drawing.Size(89, 17);
            this.radioButtonKelvin.TabIndex = 3;
            this.radioButtonKelvin.Text = "В Кельвинах";
            this.radioButtonKelvin.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            this.btnLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocation.AutoSize = true;
            this.btnLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLocation.Location = new System.Drawing.Point(165, 10);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(180, 40);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.TabStop = false;
            this.btnLocation.Text = "Определить местоположение";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Checked = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(392, 21);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCelsius.TabIndex = 3;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "В Цельсиях";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToday.AutoEllipsis = true;
            this.btnToday.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToday.Location = new System.Drawing.Point(10, 110);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(140, 40);
            this.btnToday.TabIndex = 1;
            this.btnToday.TabStop = false;
            this.btnToday.Text = "Сегодня";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnTodayWeather_Click);
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(373, 71);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(103, 17);
            this.radioButtonFahrenheit.TabIndex = 3;
            this.radioButtonFahrenheit.Text = "В Фаренгейтах";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFahrenheit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnToday, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCelsius, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonKelvin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCityDay, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtRes, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCityName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEnterCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTomorrow, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 406);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(8, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResult.Location = new System.Drawing.Point(158, 167);
            this.txtResult.Name = "txtResult";
            this.tableLayoutPanel1.SetRowSpan(this.txtResult, 2);
            this.txtResult.Size = new System.Drawing.Size(194, 234);
            this.txtResult.TabIndex = 12;
            this.txtResult.Click += new System.EventHandler(this.TxtResult_Click);
            // 
            // txtCityDay
            // 
            this.txtCityDay.AutoSize = true;
            this.txtCityDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCityDay.Location = new System.Drawing.Point(8, 247);
            this.txtCityDay.Name = "txtCityDay";
            this.txtCityDay.Size = new System.Drawing.Size(144, 154);
            this.txtCityDay.TabIndex = 15;
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRes.Location = new System.Drawing.Point(358, 167);
            this.txtRes.Name = "txtRes";
            this.tableLayoutPanel1.SetRowSpan(this.txtRes, 2);
            this.txtRes.Size = new System.Drawing.Size(118, 234);
            this.txtRes.TabIndex = 16;
            this.txtRes.Click += new System.EventHandler(this.TxtRes_Click);
            // 
            // txtCityName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCityName, 2);
            this.txtCityName.Location = new System.Drawing.Point(8, 58);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(337, 20);
            this.txtCityName.TabIndex = 17;
            this.txtCityName.TabStop = false;
            // 
            // FormWeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources._5800b2a02ac67fd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 630);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormWeatherApp";
            this.Text = "Погода от Лаврова";
            this.Load += new System.EventHandler(this.FormWeatherApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblEnterCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.RadioButton radioButtonKelvin;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtRes;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label txtCityDay;
    }
}

