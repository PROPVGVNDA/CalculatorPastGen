namespace CalculatorPastGen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            input = new Label();
            button1 = new Button();
            button2 = new Button();
            inputButtonSeven = new Button();
            inputButtonFour = new Button();
            inputButtonOne = new Button();
            inputButtonZero = new Button();
            button7 = new Button();
            inputButtonTwo = new Button();
            inputButtonFive = new Button();
            inputButtonEight = new Button();
            button11 = new Button();
            inputButton3 = new Button();
            inputButtonSix = new Button();
            inputButtonNine = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            numericalSystems = new GroupBox();
            radioHex = new RadioButton();
            radioOct = new RadioButton();
            radioDec = new RadioButton();
            radioBin = new RadioButton();
            inputButtonD = new Button();
            inputButtonC = new Button();
            inputButtonB = new Button();
            inputButtonA = new Button();
            inputButtonF = new Button();
            inputButtonE = new Button();
            inputButtons = new GroupBox();
            numericalSystems.SuspendLayout();
            inputButtons.SuspendLayout();
            SuspendLayout();
            // 
            // input
            // 
            input.BackColor = Color.Transparent;
            input.Font = new Font("Tahoma", 17F, FontStyle.Bold, GraphicsUnit.Point);
            input.ForeColor = Color.White;
            input.Location = new Point(12, 47);
            input.MinimumSize = new Size(275, 35);
            input.Name = "input";
            input.Size = new Size(971, 35);
            input.TabIndex = 0;
            input.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(397, 32);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 1;
            button1.Text = "+/-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonClickHandlerOperationInput;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(519, 32);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 2;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ButtonClickHandlerOperationInput;
            // 
            // inputButtonSeven
            // 
            inputButtonSeven.BackColor = SystemColors.WindowFrame;
            inputButtonSeven.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonSeven.ForeColor = Color.White;
            inputButtonSeven.Location = new Point(183, 132);
            inputButtonSeven.Name = "inputButtonSeven";
            inputButtonSeven.Size = new Size(101, 40);
            inputButtonSeven.TabIndex = 3;
            inputButtonSeven.Tag = "oct, dec, hex";
            inputButtonSeven.Text = "7";
            inputButtonSeven.UseVisualStyleBackColor = false;
            inputButtonSeven.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonFour
            // 
            inputButtonFour.BackColor = SystemColors.WindowFrame;
            inputButtonFour.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonFour.ForeColor = Color.White;
            inputButtonFour.Location = new Point(183, 180);
            inputButtonFour.Name = "inputButtonFour";
            inputButtonFour.Size = new Size(101, 40);
            inputButtonFour.TabIndex = 4;
            inputButtonFour.Tag = "oct, dec, hex";
            inputButtonFour.Text = "4";
            inputButtonFour.UseVisualStyleBackColor = false;
            inputButtonFour.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonOne
            // 
            inputButtonOne.BackColor = SystemColors.WindowFrame;
            inputButtonOne.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonOne.ForeColor = Color.White;
            inputButtonOne.Location = new Point(183, 226);
            inputButtonOne.Name = "inputButtonOne";
            inputButtonOne.Size = new Size(101, 40);
            inputButtonOne.TabIndex = 5;
            inputButtonOne.Tag = "bin, oct, dec, hex";
            inputButtonOne.Text = "1";
            inputButtonOne.UseVisualStyleBackColor = false;
            inputButtonOne.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonZero
            // 
            inputButtonZero.BackColor = SystemColors.WindowFrame;
            inputButtonZero.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonZero.ForeColor = Color.White;
            inputButtonZero.Location = new Point(183, 272);
            inputButtonZero.Name = "inputButtonZero";
            inputButtonZero.Size = new Size(101, 40);
            inputButtonZero.TabIndex = 6;
            inputButtonZero.Tag = "bin, oct, dec, hex";
            inputButtonZero.Text = "0";
            inputButtonZero.UseVisualStyleBackColor = false;
            inputButtonZero.Click += ButtonClickHandlerNumericalInput;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.WindowFrame;
            button7.Enabled = false;
            button7.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(300, 272);
            button7.Name = "button7";
            button7.Size = new Size(101, 40);
            button7.TabIndex = 10;
            button7.Text = ".";
            button7.UseVisualStyleBackColor = false;
            button7.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonTwo
            // 
            inputButtonTwo.BackColor = SystemColors.WindowFrame;
            inputButtonTwo.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonTwo.ForeColor = Color.White;
            inputButtonTwo.Location = new Point(300, 226);
            inputButtonTwo.Name = "inputButtonTwo";
            inputButtonTwo.Size = new Size(101, 40);
            inputButtonTwo.TabIndex = 9;
            inputButtonTwo.Tag = "oct, dec, hex";
            inputButtonTwo.Text = "2";
            inputButtonTwo.UseVisualStyleBackColor = false;
            inputButtonTwo.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonFive
            // 
            inputButtonFive.BackColor = SystemColors.WindowFrame;
            inputButtonFive.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonFive.ForeColor = Color.White;
            inputButtonFive.Location = new Point(300, 180);
            inputButtonFive.Name = "inputButtonFive";
            inputButtonFive.Size = new Size(101, 40);
            inputButtonFive.TabIndex = 8;
            inputButtonFive.Tag = "oct, dec, hex";
            inputButtonFive.Text = "5";
            inputButtonFive.UseVisualStyleBackColor = false;
            inputButtonFive.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonEight
            // 
            inputButtonEight.BackColor = SystemColors.WindowFrame;
            inputButtonEight.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonEight.ForeColor = Color.White;
            inputButtonEight.Location = new Point(300, 132);
            inputButtonEight.Name = "inputButtonEight";
            inputButtonEight.Size = new Size(101, 40);
            inputButtonEight.TabIndex = 7;
            inputButtonEight.Tag = "dec, hex";
            inputButtonEight.Text = "8";
            inputButtonEight.UseVisualStyleBackColor = false;
            inputButtonEight.Click += ButtonClickHandlerNumericalInput;
            // 
            // button11
            // 
            button11.BackColor = Color.OrangeRed;
            button11.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(412, 270);
            button11.Name = "button11";
            button11.Size = new Size(101, 40);
            button11.TabIndex = 14;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = false;
            button11.Click += ButtonClickHandlerOperationInput;
            // 
            // inputButton3
            // 
            inputButton3.BackColor = SystemColors.WindowFrame;
            inputButton3.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButton3.ForeColor = Color.White;
            inputButton3.Location = new Point(412, 224);
            inputButton3.Name = "inputButton3";
            inputButton3.Size = new Size(101, 40);
            inputButton3.TabIndex = 13;
            inputButton3.Tag = "oct, dec, hex";
            inputButton3.Text = "3";
            inputButton3.UseVisualStyleBackColor = false;
            inputButton3.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonSix
            // 
            inputButtonSix.BackColor = SystemColors.WindowFrame;
            inputButtonSix.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonSix.ForeColor = Color.White;
            inputButtonSix.Location = new Point(412, 178);
            inputButtonSix.Name = "inputButtonSix";
            inputButtonSix.Size = new Size(101, 40);
            inputButtonSix.TabIndex = 12;
            inputButtonSix.Tag = "oct, dec, hex";
            inputButtonSix.Text = "6";
            inputButtonSix.UseVisualStyleBackColor = false;
            inputButtonSix.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonNine
            // 
            inputButtonNine.BackColor = SystemColors.WindowFrame;
            inputButtonNine.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonNine.ForeColor = Color.White;
            inputButtonNine.Location = new Point(412, 132);
            inputButtonNine.Name = "inputButtonNine";
            inputButtonNine.Size = new Size(101, 40);
            inputButtonNine.TabIndex = 11;
            inputButtonNine.Tag = "dec, hex";
            inputButtonNine.Text = "9";
            inputButtonNine.UseVisualStyleBackColor = false;
            inputButtonNine.Click += ButtonClickHandlerNumericalInput;
            // 
            // button15
            // 
            button15.BackColor = Color.OrangeRed;
            button15.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.White;
            button15.Location = new Point(528, 270);
            button15.Name = "button15";
            button15.Size = new Size(101, 40);
            button15.TabIndex = 18;
            button15.Text = "+";
            button15.UseVisualStyleBackColor = false;
            button15.Click += ButtonClickHandlerOperationInput;
            // 
            // button16
            // 
            button16.BackColor = Color.OrangeRed;
            button16.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(528, 224);
            button16.Name = "button16";
            button16.Size = new Size(101, 40);
            button16.TabIndex = 17;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += ButtonClickHandlerOperationInput;
            // 
            // button17
            // 
            button17.BackColor = Color.OrangeRed;
            button17.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = Color.White;
            button17.Location = new Point(528, 178);
            button17.Name = "button17";
            button17.Size = new Size(101, 40);
            button17.TabIndex = 16;
            button17.Text = "*";
            button17.UseVisualStyleBackColor = false;
            button17.Click += ButtonClickHandlerOperationInput;
            // 
            // button18
            // 
            button18.BackColor = Color.OrangeRed;
            button18.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = Color.White;
            button18.Location = new Point(528, 132);
            button18.Name = "button18";
            button18.Size = new Size(101, 40);
            button18.TabIndex = 15;
            button18.Text = "/";
            button18.UseVisualStyleBackColor = false;
            button18.Click += ButtonClickHandlerOperationInput;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ButtonFace;
            button19.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button19.ForeColor = Color.Black;
            button19.Location = new Point(15, 86);
            button19.Name = "button19";
            button19.Size = new Size(74, 40);
            button19.TabIndex = 19;
            button19.Text = "<<";
            button19.UseVisualStyleBackColor = false;
            button19.Click += ButtonClickHandlerOperationInput;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ButtonFace;
            button20.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button20.ForeColor = Color.Black;
            button20.Location = new Point(102, 86);
            button20.Name = "button20";
            button20.Size = new Size(75, 40);
            button20.TabIndex = 20;
            button20.Text = ">>";
            button20.UseVisualStyleBackColor = false;
            button20.Click += ButtonClickHandlerOperationInput;
            // 
            // button21
            // 
            button21.BackColor = SystemColors.ButtonFace;
            button21.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button21.ForeColor = Color.Black;
            button21.Location = new Point(183, 86);
            button21.Name = "button21";
            button21.Size = new Size(106, 40);
            button21.TabIndex = 21;
            button21.Text = "AND";
            button21.UseVisualStyleBackColor = false;
            button21.Click += ButtonClickHandlerOperationInput;
            // 
            // button22
            // 
            button22.BackColor = SystemColors.ButtonFace;
            button22.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button22.ForeColor = Color.Black;
            button22.Location = new Point(295, 86);
            button22.Name = "button22";
            button22.Size = new Size(106, 40);
            button22.TabIndex = 22;
            button22.Text = "OR";
            button22.UseVisualStyleBackColor = false;
            button22.Click += ButtonClickHandlerOperationInput;
            // 
            // button23
            // 
            button23.BackColor = SystemColors.ButtonFace;
            button23.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button23.ForeColor = Color.Black;
            button23.Location = new Point(407, 86);
            button23.Name = "button23";
            button23.Size = new Size(106, 40);
            button23.TabIndex = 23;
            button23.Text = "XOR";
            button23.UseVisualStyleBackColor = false;
            button23.Click += ButtonClickHandlerOperationInput;
            // 
            // button24
            // 
            button24.BackColor = Color.OrangeRed;
            button24.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button24.ForeColor = Color.White;
            button24.Location = new Point(528, 86);
            button24.Name = "button24";
            button24.Size = new Size(106, 40);
            button24.TabIndex = 24;
            button24.Text = "NOT";
            button24.UseVisualStyleBackColor = false;
            button24.Click += ButtonClickHandlerOperationInput;
            // 
            // numericalSystems
            // 
            numericalSystems.Controls.Add(radioHex);
            numericalSystems.Controls.Add(radioOct);
            numericalSystems.Controls.Add(radioDec);
            numericalSystems.Controls.Add(radioBin);
            numericalSystems.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericalSystems.ForeColor = Color.White;
            numericalSystems.Location = new Point(12, 301);
            numericalSystems.Name = "numericalSystems";
            numericalSystems.Size = new Size(64, 295);
            numericalSystems.TabIndex = 25;
            numericalSystems.TabStop = false;
            // 
            // radioHex
            // 
            radioHex.AutoSize = true;
            radioHex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioHex.ForeColor = Color.White;
            radioHex.Location = new Point(6, 158);
            radioHex.Name = "radioHex";
            radioHex.Size = new Size(48, 19);
            radioHex.TabIndex = 3;
            radioHex.Text = "HEX";
            radioHex.UseVisualStyleBackColor = true;
            radioHex.CheckedChanged += NumericalSystemCheckedChanged;
            // 
            // radioOct
            // 
            radioOct.AutoSize = true;
            radioOct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioOct.ForeColor = Color.White;
            radioOct.Location = new Point(5, 57);
            radioOct.Name = "radioOct";
            radioOct.Size = new Size(48, 19);
            radioOct.TabIndex = 2;
            radioOct.Text = "OCT";
            radioOct.UseVisualStyleBackColor = true;
            radioOct.CheckedChanged += NumericalSystemCheckedChanged;
            // 
            // radioDec
            // 
            radioDec.AutoSize = true;
            radioDec.Checked = true;
            radioDec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioDec.ForeColor = Color.White;
            radioDec.Location = new Point(5, 23);
            radioDec.Name = "radioDec";
            radioDec.Size = new Size(47, 19);
            radioDec.TabIndex = 1;
            radioDec.TabStop = true;
            radioDec.Text = "DEC";
            radioDec.UseVisualStyleBackColor = true;
            radioDec.CheckedChanged += NumericalSystemCheckedChanged;
            // 
            // radioBin
            // 
            radioBin.AutoSize = true;
            radioBin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioBin.ForeColor = Color.White;
            radioBin.Location = new Point(5, 103);
            radioBin.Name = "radioBin";
            radioBin.Size = new Size(46, 19);
            radioBin.TabIndex = 0;
            radioBin.Text = "BIN";
            radioBin.UseVisualStyleBackColor = true;
            radioBin.CheckedChanged += NumericalSystemCheckedChanged;
            // 
            // inputButtonD
            // 
            inputButtonD.BackColor = SystemColors.WindowFrame;
            inputButtonD.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonD.ForeColor = Color.White;
            inputButtonD.Location = new Point(90, 272);
            inputButtonD.Name = "inputButtonD";
            inputButtonD.Size = new Size(90, 40);
            inputButtonD.TabIndex = 29;
            inputButtonD.Tag = "hex";
            inputButtonD.Text = "D";
            inputButtonD.UseVisualStyleBackColor = false;
            inputButtonD.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonC
            // 
            inputButtonC.BackColor = SystemColors.WindowFrame;
            inputButtonC.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonC.ForeColor = Color.White;
            inputButtonC.Location = new Point(91, 224);
            inputButtonC.Name = "inputButtonC";
            inputButtonC.Size = new Size(90, 40);
            inputButtonC.TabIndex = 28;
            inputButtonC.Tag = "hex";
            inputButtonC.Text = "C";
            inputButtonC.UseVisualStyleBackColor = false;
            inputButtonC.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonB
            // 
            inputButtonB.BackColor = SystemColors.WindowFrame;
            inputButtonB.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonB.ForeColor = Color.White;
            inputButtonB.Location = new Point(0, 178);
            inputButtonB.Name = "inputButtonB";
            inputButtonB.Size = new Size(90, 40);
            inputButtonB.TabIndex = 27;
            inputButtonB.Tag = "hex";
            inputButtonB.Text = "B";
            inputButtonB.UseVisualStyleBackColor = false;
            inputButtonB.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonA
            // 
            inputButtonA.BackColor = SystemColors.WindowFrame;
            inputButtonA.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonA.ForeColor = Color.White;
            inputButtonA.Location = new Point(-1, 132);
            inputButtonA.Name = "inputButtonA";
            inputButtonA.Size = new Size(90, 40);
            inputButtonA.TabIndex = 26;
            inputButtonA.Tag = "hex";
            inputButtonA.Text = "A";
            inputButtonA.UseVisualStyleBackColor = false;
            inputButtonA.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonF
            // 
            inputButtonF.BackColor = SystemColors.WindowFrame;
            inputButtonF.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonF.ForeColor = Color.White;
            inputButtonF.Location = new Point(-1, 270);
            inputButtonF.Name = "inputButtonF";
            inputButtonF.Size = new Size(90, 40);
            inputButtonF.TabIndex = 31;
            inputButtonF.Tag = "hex";
            inputButtonF.Text = "F";
            inputButtonF.UseVisualStyleBackColor = false;
            inputButtonF.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtonE
            // 
            inputButtonE.BackColor = SystemColors.WindowFrame;
            inputButtonE.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inputButtonE.ForeColor = Color.White;
            inputButtonE.Location = new Point(-1, 224);
            inputButtonE.Name = "inputButtonE";
            inputButtonE.Size = new Size(90, 40);
            inputButtonE.TabIndex = 30;
            inputButtonE.Tag = "hex";
            inputButtonE.Text = "E";
            inputButtonE.UseVisualStyleBackColor = false;
            inputButtonE.Click += ButtonClickHandlerNumericalInput;
            // 
            // inputButtons
            // 
            inputButtons.AutoSize = true;
            inputButtons.BackColor = Color.Transparent;
            inputButtons.Controls.Add(button2);
            inputButtons.Controls.Add(inputButtonA);
            inputButtons.Controls.Add(button23);
            inputButtons.Controls.Add(button1);
            inputButtons.Controls.Add(inputButtonF);
            inputButtons.Controls.Add(inputButtonSeven);
            inputButtons.Controls.Add(inputButtonB);
            inputButtons.Controls.Add(inputButtonFour);
            inputButtons.Controls.Add(inputButtonOne);
            inputButtons.Controls.Add(inputButtonE);
            inputButtons.Controls.Add(inputButtonZero);
            inputButtons.Controls.Add(button24);
            inputButtons.Controls.Add(inputButtonEight);
            inputButtons.Controls.Add(inputButtonC);
            inputButtons.Controls.Add(inputButtonFive);
            inputButtons.Controls.Add(inputButtonTwo);
            inputButtons.Controls.Add(inputButtonD);
            inputButtons.Controls.Add(button7);
            inputButtons.Controls.Add(button22);
            inputButtons.Controls.Add(inputButtonNine);
            inputButtons.Controls.Add(button21);
            inputButtons.Controls.Add(inputButtonSix);
            inputButtons.Controls.Add(button20);
            inputButtons.Controls.Add(inputButton3);
            inputButtons.Controls.Add(button19);
            inputButtons.Controls.Add(button11);
            inputButtons.Controls.Add(button15);
            inputButtons.Controls.Add(button18);
            inputButtons.Controls.Add(button16);
            inputButtons.Controls.Add(button17);
            inputButtons.FlatStyle = FlatStyle.Flat;
            inputButtons.ForeColor = Color.Transparent;
            inputButtons.Location = new Point(182, 281);
            inputButtons.Name = "inputButtons";
            inputButtons.Size = new Size(646, 334);
            inputButtons.TabIndex = 32;
            inputButtons.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(995, 608);
            Controls.Add(inputButtons);
            Controls.Add(numericalSystems);
            Controls.Add(input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "   ";
            numericalSystems.ResumeLayout(false);
            numericalSystems.PerformLayout();
            inputButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label input;
        private Button button1;
        private Button button2;
        private Button inputButtonSeven;
        private Button inputButtonFour;
        private Button inputButtonOne;
        private Button inputButtonZero;
        private Button button7;
        private Button inputButtonTwo;
        private Button inputButtonFive;
        private Button inputButtonEight;
        private Button button11;
        private Button inputButton3;
        private Button inputButtonSix;
        private Button inputButtonNine;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private GroupBox numericalSystems;
        private RadioButton radioHex;
        private RadioButton radioOct;
        private RadioButton radioDec;
        private RadioButton radioBin;
        private Button inputButtonD;
        private Button inputButtonC;
        private Button inputButtonB;
        private Button inputButtonA;
        private Button inputButtonF;
        private Button inputButtonE;
        private GroupBox inputButtons;
    }
}