namespace Vanilla_Hack
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.procID_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.procStatus_label = new System.Windows.Forms.Label();
            this.movementSpeed_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameVersion_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.compatibility_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerBase_label = new System.Windows.Forms.Label();
            this.findBase_button = new System.Windows.Forms.Button();
            this.speedHack_checkBox = new System.Windows.Forms.CheckBox();
            this.fallingHack_checkBox = new System.Windows.Forms.CheckBox();
            this.fallingSpeed_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.antiRoot_checkbox = new System.Windows.Forms.CheckBox();
            this.wallClimbing_checkBox = new System.Windows.Forms.CheckBox();
            this.noFallingDamage_checkBox = new System.Windows.Forms.CheckBox();
            this.flyHack_checkBox = new System.Windows.Forms.CheckBox();
            this.heartBeat_checkBox = new System.Windows.Forms.CheckBox();
            this.disableWarden_checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WoW Process ID:";
            // 
            // procID_label
            // 
            this.procID_label.AutoSize = true;
            this.procID_label.Location = new System.Drawing.Point(108, 9);
            this.procID_label.Name = "procID_label";
            this.procID_label.Size = new System.Drawing.Size(35, 13);
            this.procID_label.TabIndex = 2;
            this.procID_label.Text = "####";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Process Open:";
            // 
            // procStatus_label
            // 
            this.procStatus_label.AutoSize = true;
            this.procStatus_label.ForeColor = System.Drawing.Color.Crimson;
            this.procStatus_label.Location = new System.Drawing.Point(91, 28);
            this.procStatus_label.Name = "procStatus_label";
            this.procStatus_label.Size = new System.Drawing.Size(50, 13);
            this.procStatus_label.TabIndex = 4;
            this.procStatus_label.Text = "CLOSED";
            // 
            // movementSpeed_box
            // 
            this.movementSpeed_box.Location = new System.Drawing.Point(159, 184);
            this.movementSpeed_box.Name = "movementSpeed_box";
            this.movementSpeed_box.Size = new System.Drawing.Size(20, 20);
            this.movementSpeed_box.TabIndex = 5;
            this.movementSpeed_box.Text = "7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Movement Speed (default: 7)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Game Version:";
            // 
            // gameVersion_label
            // 
            this.gameVersion_label.AutoSize = true;
            this.gameVersion_label.Location = new System.Drawing.Point(91, 47);
            this.gameVersion_label.Name = "gameVersion_label";
            this.gameVersion_label.Size = new System.Drawing.Size(35, 13);
            this.gameVersion_label.TabIndex = 10;
            this.gameVersion_label.Text = "XXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Compatibility:";
            // 
            // compatibility_label
            // 
            this.compatibility_label.AutoSize = true;
            this.compatibility_label.Location = new System.Drawing.Point(83, 67);
            this.compatibility_label.Name = "compatibility_label";
            this.compatibility_label.Size = new System.Drawing.Size(53, 13);
            this.compatibility_label.TabIndex = 12;
            this.compatibility_label.Text = "Unknown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Player Base:";
            // 
            // playerBase_label
            // 
            this.playerBase_label.AutoSize = true;
            this.playerBase_label.Location = new System.Drawing.Point(81, 87);
            this.playerBase_label.Name = "playerBase_label";
            this.playerBase_label.Size = new System.Drawing.Size(66, 13);
            this.playerBase_label.TabIndex = 14;
            this.playerBase_label.Text = "0x00000000";
            // 
            // findBase_button
            // 
            this.findBase_button.Location = new System.Drawing.Point(12, 107);
            this.findBase_button.Name = "findBase_button";
            this.findBase_button.Size = new System.Drawing.Size(135, 23);
            this.findBase_button.TabIndex = 15;
            this.findBase_button.Text = "Find Player Base";
            this.findBase_button.UseVisualStyleBackColor = true;
            this.findBase_button.Click += new System.EventHandler(this.Button1_ClickAsync);
            // 
            // speedHack_checkBox
            // 
            this.speedHack_checkBox.AutoSize = true;
            this.speedHack_checkBox.Location = new System.Drawing.Point(12, 186);
            this.speedHack_checkBox.Name = "speedHack_checkBox";
            this.speedHack_checkBox.Size = new System.Drawing.Size(83, 17);
            this.speedHack_checkBox.TabIndex = 16;
            this.speedHack_checkBox.Text = "SpeedHack";
            this.speedHack_checkBox.UseVisualStyleBackColor = true;
            this.speedHack_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // fallingHack_checkBox
            // 
            this.fallingHack_checkBox.AutoSize = true;
            this.fallingHack_checkBox.Location = new System.Drawing.Point(12, 209);
            this.fallingHack_checkBox.Name = "fallingHack_checkBox";
            this.fallingHack_checkBox.Size = new System.Drawing.Size(82, 17);
            this.fallingHack_checkBox.TabIndex = 17;
            this.fallingHack_checkBox.Text = "FallingHack";
            this.fallingHack_checkBox.UseVisualStyleBackColor = true;
            this.fallingHack_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // fallingSpeed_box
            // 
            this.fallingSpeed_box.Location = new System.Drawing.Point(159, 210);
            this.fallingSpeed_box.Name = "fallingSpeed_box";
            this.fallingSpeed_box.Size = new System.Drawing.Size(20, 20);
            this.fallingSpeed_box.TabIndex = 18;
            this.fallingSpeed_box.Text = "60";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Falling Speed (default: 60)";
            // 
            // antiRoot_checkbox
            // 
            this.antiRoot_checkbox.AutoSize = true;
            this.antiRoot_checkbox.Location = new System.Drawing.Point(12, 301);
            this.antiRoot_checkbox.Name = "antiRoot_checkbox";
            this.antiRoot_checkbox.Size = new System.Drawing.Size(70, 17);
            this.antiRoot_checkbox.TabIndex = 20;
            this.antiRoot_checkbox.Text = "Anti-Root";
            this.antiRoot_checkbox.UseVisualStyleBackColor = true;
            this.antiRoot_checkbox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // wallClimbing_checkBox
            // 
            this.wallClimbing_checkBox.AutoSize = true;
            this.wallClimbing_checkBox.Location = new System.Drawing.Point(12, 232);
            this.wallClimbing_checkBox.Name = "wallClimbing_checkBox";
            this.wallClimbing_checkBox.Size = new System.Drawing.Size(89, 17);
            this.wallClimbing_checkBox.TabIndex = 21;
            this.wallClimbing_checkBox.Text = "Wall Climbing";
            this.wallClimbing_checkBox.UseVisualStyleBackColor = true;
            this.wallClimbing_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // noFallingDamage_checkBox
            // 
            this.noFallingDamage_checkBox.AutoSize = true;
            this.noFallingDamage_checkBox.Location = new System.Drawing.Point(12, 255);
            this.noFallingDamage_checkBox.Name = "noFallingDamage_checkBox";
            this.noFallingDamage_checkBox.Size = new System.Drawing.Size(116, 17);
            this.noFallingDamage_checkBox.TabIndex = 22;
            this.noFallingDamage_checkBox.Text = "No Falling Damage";
            this.noFallingDamage_checkBox.UseVisualStyleBackColor = true;
            this.noFallingDamage_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // flyHack_checkBox
            // 
            this.flyHack_checkBox.AutoSize = true;
            this.flyHack_checkBox.Location = new System.Drawing.Point(12, 278);
            this.flyHack_checkBox.Name = "flyHack_checkBox";
            this.flyHack_checkBox.Size = new System.Drawing.Size(65, 17);
            this.flyHack_checkBox.TabIndex = 23;
            this.flyHack_checkBox.Text = "FlyHack";
            this.flyHack_checkBox.UseVisualStyleBackColor = true;
            this.flyHack_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // heartBeat_checkBox
            // 
            this.heartBeat_checkBox.AutoSize = true;
            this.heartBeat_checkBox.Location = new System.Drawing.Point(12, 324);
            this.heartBeat_checkBox.Name = "heartBeat_checkBox";
            this.heartBeat_checkBox.Size = new System.Drawing.Size(134, 17);
            this.heartBeat_checkBox.TabIndex = 24;
            this.heartBeat_checkBox.Text = "Low Heartbeat Interval";
            this.heartBeat_checkBox.UseVisualStyleBackColor = true;
            this.heartBeat_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxHacks_CheckedChanged);
            // 
            // disableWarden_checkBox
            // 
            this.disableWarden_checkBox.AutoSize = true;
            this.disableWarden_checkBox.Location = new System.Drawing.Point(12, 148);
            this.disableWarden_checkBox.Name = "disableWarden_checkBox";
            this.disableWarden_checkBox.Size = new System.Drawing.Size(102, 17);
            this.disableWarden_checkBox.TabIndex = 25;
            this.disableWarden_checkBox.Text = "Disable Warden";
            this.disableWarden_checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vanilla_Hack.Properties.Resources.graffiti2;
            this.pictureBox1.Location = new System.Drawing.Point(166, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.disableWarden_checkBox);
            this.Controls.Add(this.heartBeat_checkBox);
            this.Controls.Add(this.flyHack_checkBox);
            this.Controls.Add(this.noFallingDamage_checkBox);
            this.Controls.Add(this.wallClimbing_checkBox);
            this.Controls.Add(this.antiRoot_checkbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fallingSpeed_box);
            this.Controls.Add(this.fallingHack_checkBox);
            this.Controls.Add(this.speedHack_checkBox);
            this.Controls.Add(this.findBase_button);
            this.Controls.Add(this.playerBase_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compatibility_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gameVersion_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.movementSpeed_box);
            this.Controls.Add(this.procStatus_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procID_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanilla Hack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label procID_label;
        private System.Windows.Forms.Label procStatus_label;
        private System.Windows.Forms.Label gameVersion_label;
        private System.Windows.Forms.Label compatibility_label;
        private System.Windows.Forms.Label playerBase_label;
        private System.Windows.Forms.TextBox movementSpeed_box;
        private System.Windows.Forms.Button findBase_button;
        private System.Windows.Forms.CheckBox speedHack_checkBox;
        private System.Windows.Forms.CheckBox fallingHack_checkBox;
        private System.Windows.Forms.TextBox fallingSpeed_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox antiRoot_checkbox;
        private System.Windows.Forms.CheckBox wallClimbing_checkBox;
        private System.Windows.Forms.CheckBox noFallingDamage_checkBox;
        private System.Windows.Forms.CheckBox flyHack_checkBox;
        private System.Windows.Forms.CheckBox heartBeat_checkBox;
        private System.Windows.Forms.CheckBox disableWarden_checkBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

