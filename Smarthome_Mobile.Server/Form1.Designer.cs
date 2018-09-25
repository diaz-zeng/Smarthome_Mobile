namespace Smarthome_Mobile.Server
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.portName = new System.Windows.Forms.ToolStripComboBox();
            this.sysRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ipInput = new System.Windows.Forms.ToolStripTextBox();
            this.netRun = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Node3_RSSI = new System.Windows.Forms.Label();
            this.Node2_RSSI = new System.Windows.Forms.Label();
            this.Node1_RSSI = new System.Windows.Forms.Label();
            this.Node3_MAC = new System.Windows.Forms.Label();
            this.Node2_MAC = new System.Windows.Forms.Label();
            this.Node1_MAC = new System.Windows.Forms.Label();
            this.Node3_SA = new System.Windows.Forms.Label();
            this.Node2_SA = new System.Windows.Forms.Label();
            this.Node1_SA = new System.Windows.Forms.Label();
            this.Node3 = new System.Windows.Forms.Label();
            this.Node2 = new System.Windows.Forms.Label();
            this.Node1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labFireWarning = new System.Windows.Forms.Label();
            this.labLight = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReadFireWarning = new System.Windows.Forms.Button();
            this.btnReadSensorData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smarthome_DatabaseDataSet = new Smarthome_Mobile.Smarthome_DatabaseDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.warningTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fireWarningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataTableAdapter = new Smarthome_Mobile.Smarthome_DatabaseDataSetTableAdapters.SensorDataTableAdapter();
            this.fireWarningTableAdapter = new Smarthome_Mobile.Smarthome_DatabaseDataSetTableAdapters.FireWarningTableAdapter();
            this.TempUpdata = new System.Windows.Forms.Timer(this.components);
            this.HumidityUpdata = new System.Windows.Forms.Timer(this.components);
            this.LightUpdata = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smarthome_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireWarningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.portName,
            this.sysRun,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.ipInput,
            this.netRun});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "通信端口";
            // 
            // portName
            // 
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(121, 25);
            // 
            // sysRun
            // 
            this.sysRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sysRun.Image = ((System.Drawing.Image)(resources.GetObject("sysRun.Image")));
            this.sysRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sysRun.Name = "sysRun";
            this.sysRun.Size = new System.Drawing.Size(60, 22);
            this.sysRun.Text = "启动系统";
            this.sysRun.Click += new System.EventHandler(this.sysRun_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "本机IP";
            // 
            // ipInput
            // 
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(121, 25);
            // 
            // netRun
            // 
            this.netRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.netRun.Image = ((System.Drawing.Image)(resources.GetObject("netRun.Image")));
            this.netRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.netRun.Name = "netRun";
            this.netRun.Size = new System.Drawing.Size(60, 22);
            this.netRun.Text = "建立通讯";
            this.netRun.Click += new System.EventHandler(this.netRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "手动超控";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Node3_RSSI);
            this.groupBox2.Controls.Add(this.Node2_RSSI);
            this.groupBox2.Controls.Add(this.Node1_RSSI);
            this.groupBox2.Controls.Add(this.Node3_MAC);
            this.groupBox2.Controls.Add(this.Node2_MAC);
            this.groupBox2.Controls.Add(this.Node1_MAC);
            this.groupBox2.Controls.Add(this.Node3_SA);
            this.groupBox2.Controls.Add(this.Node2_SA);
            this.groupBox2.Controls.Add(this.Node1_SA);
            this.groupBox2.Controls.Add(this.Node3);
            this.groupBox2.Controls.Add(this.Node2);
            this.groupBox2.Controls.Add(this.Node1);
            this.groupBox2.Location = new System.Drawing.Point(347, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "节点信息";
            // 
            // Node3_RSSI
            // 
            this.Node3_RSSI.AutoSize = true;
            this.Node3_RSSI.Location = new System.Drawing.Point(269, 101);
            this.Node3_RSSI.Name = "Node3_RSSI";
            this.Node3_RSSI.Size = new System.Drawing.Size(17, 12);
            this.Node3_RSSI.TabIndex = 11;
            this.Node3_RSSI.Text = "00";
            // 
            // Node2_RSSI
            // 
            this.Node2_RSSI.AutoSize = true;
            this.Node2_RSSI.Location = new System.Drawing.Point(269, 74);
            this.Node2_RSSI.Name = "Node2_RSSI";
            this.Node2_RSSI.Size = new System.Drawing.Size(17, 12);
            this.Node2_RSSI.TabIndex = 10;
            this.Node2_RSSI.Text = "00";
            // 
            // Node1_RSSI
            // 
            this.Node1_RSSI.AutoSize = true;
            this.Node1_RSSI.Location = new System.Drawing.Point(269, 47);
            this.Node1_RSSI.Name = "Node1_RSSI";
            this.Node1_RSSI.Size = new System.Drawing.Size(17, 12);
            this.Node1_RSSI.TabIndex = 9;
            this.Node1_RSSI.Text = "00";
            // 
            // Node3_MAC
            // 
            this.Node3_MAC.AutoSize = true;
            this.Node3_MAC.Location = new System.Drawing.Point(108, 101);
            this.Node3_MAC.Name = "Node3_MAC";
            this.Node3_MAC.Size = new System.Drawing.Size(143, 12);
            this.Node3_MAC.TabIndex = 8;
            this.Node3_MAC.Text = "00-00-00-00-00-00-00-00";
            // 
            // Node2_MAC
            // 
            this.Node2_MAC.AutoSize = true;
            this.Node2_MAC.Location = new System.Drawing.Point(108, 74);
            this.Node2_MAC.Name = "Node2_MAC";
            this.Node2_MAC.Size = new System.Drawing.Size(143, 12);
            this.Node2_MAC.TabIndex = 7;
            this.Node2_MAC.Text = "00-00-00-00-00-00-00-00";
            // 
            // Node1_MAC
            // 
            this.Node1_MAC.AutoSize = true;
            this.Node1_MAC.Location = new System.Drawing.Point(108, 47);
            this.Node1_MAC.Name = "Node1_MAC";
            this.Node1_MAC.Size = new System.Drawing.Size(143, 12);
            this.Node1_MAC.TabIndex = 6;
            this.Node1_MAC.Text = "00-00-00-00-00-00-00-00";
            // 
            // Node3_SA
            // 
            this.Node3_SA.AutoSize = true;
            this.Node3_SA.Location = new System.Drawing.Point(73, 101);
            this.Node3_SA.Name = "Node3_SA";
            this.Node3_SA.Size = new System.Drawing.Size(29, 12);
            this.Node3_SA.TabIndex = 5;
            this.Node3_SA.Text = "FFFF";
            // 
            // Node2_SA
            // 
            this.Node2_SA.AutoSize = true;
            this.Node2_SA.Location = new System.Drawing.Point(73, 74);
            this.Node2_SA.Name = "Node2_SA";
            this.Node2_SA.Size = new System.Drawing.Size(29, 12);
            this.Node2_SA.TabIndex = 4;
            this.Node2_SA.Text = "FFFF";
            // 
            // Node1_SA
            // 
            this.Node1_SA.AutoSize = true;
            this.Node1_SA.Location = new System.Drawing.Point(73, 47);
            this.Node1_SA.Name = "Node1_SA";
            this.Node1_SA.Size = new System.Drawing.Size(29, 12);
            this.Node1_SA.TabIndex = 3;
            this.Node1_SA.Text = "FFFF";
            // 
            // Node3
            // 
            this.Node3.AutoSize = true;
            this.Node3.Location = new System.Drawing.Point(30, 101);
            this.Node3.Name = "Node3";
            this.Node3.Size = new System.Drawing.Size(35, 12);
            this.Node3.TabIndex = 2;
            this.Node3.Text = "Node3";
            // 
            // Node2
            // 
            this.Node2.AutoSize = true;
            this.Node2.Location = new System.Drawing.Point(30, 74);
            this.Node2.Name = "Node2";
            this.Node2.Size = new System.Drawing.Size(35, 12);
            this.Node2.TabIndex = 1;
            this.Node2.Text = "Node2";
            // 
            // Node1
            // 
            this.Node1.AutoSize = true;
            this.Node1.Location = new System.Drawing.Point(30, 47);
            this.Node1.Name = "Node1";
            this.Node1.Size = new System.Drawing.Size(35, 12);
            this.Node1.TabIndex = 0;
            this.Node1.Text = "Node1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.labFireWarning);
            this.groupBox3.Controls.Add(this.labLight);
            this.groupBox3.Controls.Add(this.labHumidity);
            this.groupBox3.Controls.Add(this.labTemp);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 225);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据反馈";
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea2";
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea3";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(184, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Temp";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Light";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(490, 199);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // labFireWarning
            // 
            this.labFireWarning.AutoSize = true;
            this.labFireWarning.Location = new System.Drawing.Point(107, 102);
            this.labFireWarning.Name = "labFireWarning";
            this.labFireWarning.Size = new System.Drawing.Size(29, 12);
            this.labFireWarning.TabIndex = 7;
            this.labFireWarning.Text = "安全";
            this.labFireWarning.TextChanged += new System.EventHandler(this.labFireWarning_TextChanged);
            // 
            // labLight
            // 
            this.labLight.AutoSize = true;
            this.labLight.Location = new System.Drawing.Point(107, 82);
            this.labLight.Name = "labLight";
            this.labLight.Size = new System.Drawing.Size(23, 12);
            this.labLight.TabIndex = 6;
            this.labLight.Text = "0.0";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.Location = new System.Drawing.Point(107, 62);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(23, 12);
            this.labHumidity.TabIndex = 5;
            this.labHumidity.Text = "0.0";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Location = new System.Drawing.Point(107, 42);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(23, 12);
            this.labTemp.TabIndex = 4;
            this.labTemp.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "火灾警报";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "光照";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "湿度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "温度";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReadFireWarning);
            this.groupBox4.Controls.Add(this.btnReadSensorData);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(699, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 400);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据库";
            // 
            // btnReadFireWarning
            // 
            this.btnReadFireWarning.Location = new System.Drawing.Point(141, 41);
            this.btnReadFireWarning.Name = "btnReadFireWarning";
            this.btnReadFireWarning.Size = new System.Drawing.Size(129, 23);
            this.btnReadFireWarning.TabIndex = 7;
            this.btnReadFireWarning.Text = "查看火灾警报记录";
            this.btnReadFireWarning.UseVisualStyleBackColor = true;
            this.btnReadFireWarning.Click += new System.EventHandler(this.btnReadFireWarning_Click);
            // 
            // btnReadSensorData
            // 
            this.btnReadSensorData.Location = new System.Drawing.Point(6, 41);
            this.btnReadSensorData.Name = "btnReadSensorData";
            this.btnReadSensorData.Size = new System.Drawing.Size(129, 23);
            this.btnReadSensorData.TabIndex = 6;
            this.btnReadSensorData.Text = "查看传感器数据记录";
            this.btnReadSensorData.UseVisualStyleBackColor = true;
            this.btnReadSensorData.Click += new System.EventHandler(this.btnReadSensorData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorTypeDataGridViewTextBoxColumn,
            this.sensorDataDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sensorDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(309, 321);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // sensorTypeDataGridViewTextBoxColumn
            // 
            this.sensorTypeDataGridViewTextBoxColumn.DataPropertyName = "SensorType";
            this.sensorTypeDataGridViewTextBoxColumn.HeaderText = "传感器类型";
            this.sensorTypeDataGridViewTextBoxColumn.Name = "sensorTypeDataGridViewTextBoxColumn";
            this.sensorTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorDataDataGridViewTextBoxColumn
            // 
            this.sensorDataDataGridViewTextBoxColumn.DataPropertyName = "SensorData";
            this.sensorDataDataGridViewTextBoxColumn.HeaderText = "数值";
            this.sensorDataDataGridViewTextBoxColumn.Name = "sensorDataDataGridViewTextBoxColumn";
            this.sensorDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorDataBindingSource
            // 
            this.sensorDataBindingSource.DataMember = "SensorData";
            this.sensorDataBindingSource.DataSource = this.smarthome_DatabaseDataSet;
            // 
            // smarthome_DatabaseDataSet
            // 
            this.smarthome_DatabaseDataSet.DataSetName = "Smarthome_DatabaseDataSet";
            this.smarthome_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warningTimeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fireWarningBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(309, 321);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Visible = false;
            // 
            // warningTimeDataGridViewTextBoxColumn
            // 
            this.warningTimeDataGridViewTextBoxColumn.DataPropertyName = "WarningTime";
            this.warningTimeDataGridViewTextBoxColumn.HeaderText = "触发时间";
            this.warningTimeDataGridViewTextBoxColumn.Name = "warningTimeDataGridViewTextBoxColumn";
            this.warningTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.warningTimeDataGridViewTextBoxColumn.Width = 260;
            // 
            // fireWarningBindingSource
            // 
            this.fireWarningBindingSource.DataMember = "FireWarning";
            this.fireWarningBindingSource.DataSource = this.smarthome_DatabaseDataSet;
            // 
            // sensorDataTableAdapter
            // 
            this.sensorDataTableAdapter.ClearBeforeFill = true;
            // 
            // fireWarningTableAdapter
            // 
            this.fireWarningTableAdapter.ClearBeforeFill = true;
            // 
            // TempUpdata
            // 
            this.TempUpdata.Interval = 15000;
            this.TempUpdata.Tick += new System.EventHandler(this.TempUpdata_Tick);
            // 
            // HumidityUpdata
            // 
            this.HumidityUpdata.Interval = 15000;
            this.HumidityUpdata.Tick += new System.EventHandler(this.HumidityUpdata_Tick);
            // 
            // LightUpdata
            // 
            this.LightUpdata.Interval = 15000;
            this.LightUpdata.Tick += new System.EventHandler(this.LightUpdata_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smarthome_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireWarningBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox portName;
        private System.Windows.Forms.ToolStripButton sysRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox ipInput;
        private System.Windows.Forms.ToolStripButton netRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Node3_RSSI;
        private System.Windows.Forms.Label Node2_RSSI;
        private System.Windows.Forms.Label Node1_RSSI;
        private System.Windows.Forms.Label Node3_MAC;
        private System.Windows.Forms.Label Node2_MAC;
        private System.Windows.Forms.Label Node1_MAC;
        private System.Windows.Forms.Label Node3_SA;
        private System.Windows.Forms.Label Node2_SA;
        private System.Windows.Forms.Label Node1_SA;
        private System.Windows.Forms.Label Node3;
        private System.Windows.Forms.Label Node2;
        private System.Windows.Forms.Label Node1;
        private System.Windows.Forms.Label labFireWarning;
        private System.Windows.Forms.Label labLight;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReadFireWarning;
        private System.Windows.Forms.Button btnReadSensorData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Smarthome_DatabaseDataSet smarthome_DatabaseDataSet;
        private Smarthome_DatabaseDataSetTableAdapters.SensorDataTableAdapter sensorDataTableAdapter;
        private Smarthome_DatabaseDataSetTableAdapters.FireWarningTableAdapter fireWarningTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warningTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fireWarningBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sensorDataBindingSource;
        private System.Windows.Forms.Timer TempUpdata;
        private System.Windows.Forms.Timer HumidityUpdata;
        private System.Windows.Forms.Timer LightUpdata;
    }
}

