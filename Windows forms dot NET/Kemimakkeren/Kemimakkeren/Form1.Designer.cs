namespace Kemimakkeren
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Title = new System.Windows.Forms.Label();
            this.getDirButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xValues = new System.Windows.Forms.ListBox();
            this.yValues = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chosenXValue = new System.Windows.Forms.Label();
            this.chosenYValue = new System.Windows.Forms.Label();
            this.initPlot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(176, 10);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(148, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Kemimakkeren";
            // 
            // getDirButton
            // 
            this.getDirButton.Location = new System.Drawing.Point(190, 50);
            this.getDirButton.Name = "getDirButton";
            this.getDirButton.Size = new System.Drawing.Size(110, 30);
            this.getDirButton.TabIndex = 1;
            this.getDirButton.Text = "Vælg Excel-fil";
            this.getDirButton.UseVisualStyleBackColor = true;
            this.getDirButton.Click += new System.EventHandler(this.getDirButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xValues
            // 
            this.xValues.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValues.FormattingEnabled = true;
            this.xValues.ItemHeight = 15;
            this.xValues.Location = new System.Drawing.Point(50, 129);
            this.xValues.Name = "xValues";
            this.xValues.Size = new System.Drawing.Size(120, 79);
            this.xValues.TabIndex = 2;
            this.xValues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.xValues_MouseDoubleClick);
            // 
            // yValues
            // 
            this.yValues.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValues.FormattingEnabled = true;
            this.yValues.ItemHeight = 15;
            this.yValues.Location = new System.Drawing.Point(324, 129);
            this.yValues.Name = "yValues";
            this.yValues.Size = new System.Drawing.Size(120, 79);
            this.yValues.TabIndex = 3;
            this.yValues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.yValues_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vælg primær kolonne (x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vælg sekundær kolonne (y)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Åben output placering";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chosenXValue
            // 
            this.chosenXValue.AutoSize = true;
            this.chosenXValue.ForeColor = System.Drawing.Color.Red;
            this.chosenXValue.Location = new System.Drawing.Point(45, 210);
            this.chosenXValue.Name = "chosenXValue";
            this.chosenXValue.Size = new System.Drawing.Size(46, 19);
            this.chosenXValue.TabIndex = 7;
            this.chosenXValue.Text = "Valgt: ";
            // 
            // chosenYValue
            // 
            this.chosenYValue.AutoSize = true;
            this.chosenYValue.ForeColor = System.Drawing.Color.Red;
            this.chosenYValue.Location = new System.Drawing.Point(320, 210);
            this.chosenYValue.Name = "chosenYValue";
            this.chosenYValue.Size = new System.Drawing.Size(46, 19);
            this.chosenYValue.TabIndex = 8;
            this.chosenYValue.Text = "Valgt: ";
            // 
            // initPlot
            // 
            this.initPlot.Location = new System.Drawing.Point(210, 250);
            this.initPlot.Name = "initPlot";
            this.initPlot.Size = new System.Drawing.Size(80, 30);
            this.initPlot.TabIndex = 9;
            this.initPlot.Text = "PLOT!";
            this.initPlot.UseVisualStyleBackColor = true;
            this.initPlot.Click += new System.EventHandler(this.initPlot_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.initPlot);
            this.Controls.Add(this.chosenYValue);
            this.Controls.Add(this.chosenXValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yValues);
            this.Controls.Add(this.xValues);
            this.Controls.Add(this.getDirButton);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form";
            this.Text = "Kemimakkeren - Victor Boesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button getDirButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox xValues;
        private System.Windows.Forms.ListBox yValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label chosenXValue;
        private System.Windows.Forms.Label chosenYValue;
        private System.Windows.Forms.Button initPlot;
    }
}

