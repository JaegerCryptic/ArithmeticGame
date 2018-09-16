namespace ArithmeticGame
{
    partial class InstructorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmboOperator = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridArray = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.btnSort3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstBoxLinked = new System.Windows.Forms.ListBox();
            this.btnDisplayLinkList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDisplayPreOrder = new System.Windows.Forms.Button();
            this.btnSavePreOrder = new System.Windows.Forms.Button();
            this.btnDisplayInOrder = new System.Windows.Forms.Button();
            this.btnSaveInOrder = new System.Windows.Forms.Button();
            this.btnDisplayPostOrder = new System.Windows.Forms.Button();
            this.btnSavePostOrder = new System.Windows.Forms.Button();
            this.txtBinaryTree = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmboOperator);
            this.panel1.Controls.Add(this.txtAnswer);
            this.panel1.Controls.Add(this.txtSecondNumber);
            this.panel1.Controls.Add(this.txtFirstNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 230);
            this.panel1.TabIndex = 1;
            // 
            // cmboOperator
            // 
            this.cmboOperator.BackColor = System.Drawing.SystemColors.Window;
            this.cmboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboOperator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmboOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboOperator.FormattingEnabled = true;
            this.cmboOperator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmboOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "÷"});
            this.cmboOperator.Location = new System.Drawing.Point(173, 87);
            this.cmboOperator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboOperator.Name = "cmboOperator";
            this.cmboOperator.Size = new System.Drawing.Size(132, 28);
            this.cmboOperator.TabIndex = 4;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(173, 156);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(132, 26);
            this.txtAnswer.TabIndex = 8;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNumber.Location = new System.Drawing.Point(173, 122);
            this.txtSecondNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(132, 26);
            this.txtSecondNumber.TabIndex = 7;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNumber.Location = new System.Drawing.Point(173, 53);
            this.txtFirstNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(132, 26);
            this.txtFirstNumber.TabIndex = 5;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.txtFirstNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Enter question, then click Send.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(15, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Second Number:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(189, 196);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Operator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Number:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(681, 318);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(373, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Array of questions asked";
            // 
            // dataGridArray
            // 
            this.dataGridArray.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArray.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridArray.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridArray.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridArray.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArray.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridArray.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridArray.EnableHeadersVisualStyles = false;
            this.dataGridArray.Location = new System.Drawing.Point(377, 119);
            this.dataGridArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridArray.MultiSelect = false;
            this.dataGridArray.Name = "dataGridArray";
            this.dataGridArray.RowHeadersVisible = false;
            this.dataGridArray.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridArray.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridArray.Size = new System.Drawing.Size(403, 164);
            this.dataGridArray.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(373, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sort:";
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(424, 283);
            this.btnSort1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(121, 28);
            this.btnSort1.TabIndex = 12;
            this.btnSort1.Text = "1";
            this.btnSort1.UseVisualStyleBackColor = true;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // btnSort2
            // 
            this.btnSort2.Location = new System.Drawing.Point(543, 283);
            this.btnSort2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(121, 28);
            this.btnSort2.TabIndex = 13;
            this.btnSort2.Text = "2";
            this.btnSort2.UseVisualStyleBackColor = true;
            this.btnSort2.Click += new System.EventHandler(this.btnSort2_Click);
            // 
            // btnSort3
            // 
            this.btnSort3.Location = new System.Drawing.Point(660, 283);
            this.btnSort3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort3.Name = "btnSort3";
            this.btnSort3.Size = new System.Drawing.Size(121, 28);
            this.btnSort3.TabIndex = 14;
            this.btnSort3.Text = "3";
            this.btnSort3.UseVisualStyleBackColor = true;
            this.btnSort3.Click += new System.EventHandler(this.btnSort3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(11, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Linked List (of all incorrectly answered excercises):";
            // 
            // lstBoxLinked
            // 
            this.lstBoxLinked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxLinked.ItemHeight = 20;
            this.lstBoxLinked.Location = new System.Drawing.Point(15, 368);
            this.lstBoxLinked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBoxLinked.Name = "lstBoxLinked";
            this.lstBoxLinked.Size = new System.Drawing.Size(787, 64);
            this.lstBoxLinked.TabIndex = 16;
            // 
            // btnDisplayLinkList
            // 
            this.btnDisplayLinkList.Location = new System.Drawing.Point(703, 459);
            this.btnDisplayLinkList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayLinkList.Name = "btnDisplayLinkList";
            this.btnDisplayLinkList.Size = new System.Drawing.Size(100, 28);
            this.btnDisplayLinkList.TabIndex = 17;
            this.btnDisplayLinkList.Text = "Display";
            this.btnDisplayLinkList.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(16, 486);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(508, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Binary Tree (of all questions - added in the order they were asked):";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(11, 610);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Pre-Order";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(337, 610);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "In-Order";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(680, 610);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "Post-Order";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisplayPreOrder
            // 
            this.btnDisplayPreOrder.Location = new System.Drawing.Point(9, 640);
            this.btnDisplayPreOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayPreOrder.Name = "btnDisplayPreOrder";
            this.btnDisplayPreOrder.Size = new System.Drawing.Size(65, 28);
            this.btnDisplayPreOrder.TabIndex = 23;
            this.btnDisplayPreOrder.Text = "Display";
            this.btnDisplayPreOrder.UseVisualStyleBackColor = true;
            this.btnDisplayPreOrder.Click += new System.EventHandler(this.btnDisplayPreOrder_Click);
            // 
            // btnSavePreOrder
            // 
            this.btnSavePreOrder.Location = new System.Drawing.Point(69, 640);
            this.btnSavePreOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSavePreOrder.Name = "btnSavePreOrder";
            this.btnSavePreOrder.Size = new System.Drawing.Size(65, 28);
            this.btnSavePreOrder.TabIndex = 24;
            this.btnSavePreOrder.Text = "Save";
            this.btnSavePreOrder.UseVisualStyleBackColor = true;
            // 
            // btnDisplayInOrder
            // 
            this.btnDisplayInOrder.Location = new System.Drawing.Point(336, 640);
            this.btnDisplayInOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayInOrder.Name = "btnDisplayInOrder";
            this.btnDisplayInOrder.Size = new System.Drawing.Size(65, 28);
            this.btnDisplayInOrder.TabIndex = 25;
            this.btnDisplayInOrder.Text = "Display";
            this.btnDisplayInOrder.UseVisualStyleBackColor = true;
            this.btnDisplayInOrder.Click += new System.EventHandler(this.btnDisplayInOrder_Click);
            // 
            // btnSaveInOrder
            // 
            this.btnSaveInOrder.Location = new System.Drawing.Point(396, 640);
            this.btnSaveInOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveInOrder.Name = "btnSaveInOrder";
            this.btnSaveInOrder.Size = new System.Drawing.Size(65, 28);
            this.btnSaveInOrder.TabIndex = 26;
            this.btnSaveInOrder.Text = "Save";
            this.btnSaveInOrder.UseVisualStyleBackColor = true;
            // 
            // btnDisplayPostOrder
            // 
            this.btnDisplayPostOrder.Location = new System.Drawing.Point(679, 640);
            this.btnDisplayPostOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayPostOrder.Name = "btnDisplayPostOrder";
            this.btnDisplayPostOrder.Size = new System.Drawing.Size(65, 28);
            this.btnDisplayPostOrder.TabIndex = 27;
            this.btnDisplayPostOrder.Text = "Display";
            this.btnDisplayPostOrder.UseVisualStyleBackColor = true;
            this.btnDisplayPostOrder.Click += new System.EventHandler(this.btnDisplayPostOrder_Click);
            // 
            // btnSavePostOrder
            // 
            this.btnSavePostOrder.Location = new System.Drawing.Point(739, 640);
            this.btnSavePostOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSavePostOrder.Name = "btnSavePostOrder";
            this.btnSavePostOrder.Size = new System.Drawing.Size(65, 28);
            this.btnSavePostOrder.TabIndex = 28;
            this.btnSavePostOrder.Text = "Save";
            this.btnSavePostOrder.UseVisualStyleBackColor = true;
            // 
            // txtBinaryTree
            // 
            this.txtBinaryTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinaryTree.Location = new System.Drawing.Point(15, 510);
            this.txtBinaryTree.Margin = new System.Windows.Forms.Padding(4);
            this.txtBinaryTree.Multiline = true;
            this.txtBinaryTree.Name = "txtBinaryTree";
            this.txtBinaryTree.Size = new System.Drawing.Size(787, 64);
            this.txtBinaryTree.TabIndex = 9;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(819, 674);
            this.Controls.Add(this.txtBinaryTree);
            this.Controls.Add(this.btnSavePostOrder);
            this.Controls.Add(this.btnDisplayPostOrder);
            this.Controls.Add(this.btnSaveInOrder);
            this.Controls.Add(this.btnDisplayInOrder);
            this.Controls.Add(this.btnSavePreOrder);
            this.Controls.Add(this.btnDisplayPreOrder);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDisplayLinkList);
            this.Controls.Add(this.lstBoxLinked);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSort3);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridArray);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InstructorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmboOperator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridArray;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.Button btnSort3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstBoxLinked;
        private System.Windows.Forms.Button btnDisplayLinkList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDisplayPreOrder;
        private System.Windows.Forms.Button btnSavePreOrder;
        private System.Windows.Forms.Button btnDisplayInOrder;
        private System.Windows.Forms.Button btnSaveInOrder;
        private System.Windows.Forms.Button btnDisplayPostOrder;
        private System.Windows.Forms.Button btnSavePostOrder;
        private System.Windows.Forms.TextBox txtBinaryTree;
    }
}

