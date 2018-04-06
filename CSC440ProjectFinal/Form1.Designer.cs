namespace CSC440ProjectFinal
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
            this.Header = new System.Windows.Forms.Label();
            this.Train1 = new System.Windows.Forms.Button();
            this.Train2 = new System.Windows.Forms.Button();
            this.Train4 = new System.Windows.Forms.Button();
            this.Train3 = new System.Windows.Forms.Button();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FloralWhite;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(57, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(539, 33);
            this.Header.TabIndex = 0;
            this.Header.Text = "Auto Train Crossing Signal Management";
            // 
            // Train1
            // 
            this.Train1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train1.Location = new System.Drawing.Point(30, 85);
            this.Train1.Name = "Train1";
            this.Train1.Size = new System.Drawing.Size(100, 42);
            this.Train1.TabIndex = 1;
            this.Train1.Text = "Train 1";
            this.Train1.UseVisualStyleBackColor = true;
            this.Train1.Click += new System.EventHandler(this.Train1_Click);
            // 
            // Train2
            // 
            this.Train2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train2.Location = new System.Drawing.Point(165, 85);
            this.Train2.Name = "Train2";
            this.Train2.Size = new System.Drawing.Size(100, 42);
            this.Train2.TabIndex = 1;
            this.Train2.Text = "Train 2";
            this.Train2.UseVisualStyleBackColor = true;
            // 
            // Train4
            // 
            this.Train4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train4.Location = new System.Drawing.Point(165, 158);
            this.Train4.Name = "Train4";
            this.Train4.Size = new System.Drawing.Size(100, 42);
            this.Train4.TabIndex = 1;
            this.Train4.Text = "Train 4";
            this.Train4.UseMnemonic = false;
            this.Train4.UseVisualStyleBackColor = true;
            // 
            // Train3
            // 
            this.Train3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train3.Location = new System.Drawing.Point(30, 158);
            this.Train3.Name = "Train3";
            this.Train3.Size = new System.Drawing.Size(100, 42);
            this.Train3.TabIndex = 1;
            this.Train3.Text = "Train 3";
            this.Train3.UseVisualStyleBackColor = true;
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClockLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(333, 101);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(287, 75);
            this.ClockLabel.TabIndex = 2;
            this.ClockLabel.Text = "00:00:00";
            // 
            // Map
            // 
            this.Map.Font = new System.Drawing.Font("Minion Pro Med", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map.Location = new System.Drawing.Point(30, 225);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(235, 86);
            this.Map.TabIndex = 3;
            this.Map.Text = "Area Map";
            this.Map.UseVisualStyleBackColor = true;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(651, 582);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.Train3);
            this.Controls.Add(this.Train4);
            this.Controls.Add(this.Train2);
            this.Controls.Add(this.Train1);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "area map e click kore dekhto chole naki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button Train1;
        private System.Windows.Forms.Button Train2;
        private System.Windows.Forms.Button Train4;
        private System.Windows.Forms.Button Train3;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Button Map;
    }
}

