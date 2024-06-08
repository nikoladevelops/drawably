using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.TopPanel
{
    public class TopPanel : UserControl
    {
        public TopPanel()
        {

        }

        private void InitializeComponent()
        {
            customMenuStrip1 = new CustomMenuStrip.CustomMenuStrip();
            testingggToolStripMenuItem = new ToolStripMenuItem();
            dxfhdsafhToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adsfhfdshToolStripMenuItem = new ToolStripMenuItem();
            mainToolsPanel1 = new CustomMenuStrip.MainToolsPanel();
            mainControlsPanel = new TableLayoutPanel();
            additionalPanel = new Panel();
            customMenuStrip1.SuspendLayout();
            mainControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // customMenuStrip1
            // 
            customMenuStrip1.BackColor = Color.Black;
            customMenuStrip1.Dock = DockStyle.Fill;
            customMenuStrip1.ForeColor = Color.White;
            customMenuStrip1.Items.AddRange(new ToolStripItem[] { testingggToolStripMenuItem });
            customMenuStrip1.Location = new Point(0, 0);
            customMenuStrip1.Name = "customMenuStrip1";
            customMenuStrip1.Size = new Size(248, 35);
            customMenuStrip1.TabIndex = 15;
            customMenuStrip1.Text = "customMenuStrip1";
            // 
            // testingggToolStripMenuItem
            // 
            testingggToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dxfhdsafhToolStripMenuItem, toolStripMenuItem1, adsfhfdshToolStripMenuItem });
            testingggToolStripMenuItem.Name = "testingggToolStripMenuItem";
            testingggToolStripMenuItem.Size = new Size(37, 31);
            testingggToolStripMenuItem.Text = "File";
            // 
            // dxfhdsafhToolStripMenuItem
            // 
            dxfhdsafhToolStripMenuItem.ForeColor = Color.White;
            dxfhdsafhToolStripMenuItem.Name = "dxfhdsafhToolStripMenuItem";
            dxfhdsafhToolStripMenuItem.Size = new Size(114, 22);
            dxfhdsafhToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(114, 22);
            toolStripMenuItem1.Text = "Save";
            // 
            // adsfhfdshToolStripMenuItem
            // 
            adsfhfdshToolStripMenuItem.ForeColor = Color.White;
            adsfhfdshToolStripMenuItem.Name = "adsfhfdshToolStripMenuItem";
            adsfhfdshToolStripMenuItem.Size = new Size(114, 22);
            adsfhfdshToolStripMenuItem.Text = "Save As";
            // 
            // mainToolsPanel1
            // 
            mainToolsPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mainToolsPanel1.ColorsWindow = null;
            mainToolsPanel1.LayersWindow = null;
            mainToolsPanel1.Location = new Point(516, 3);
            mainToolsPanel1.Name = "mainToolsPanel1";
            mainToolsPanel1.Size = new Size(97, 29);
            mainToolsPanel1.TabIndex = 17;
            mainToolsPanel1.ToolsWindow = null;
            // 
            // mainControlsPanel
            // 
            mainControlsPanel.BackColor = Color.Black;
            mainControlsPanel.ColumnCount = 2;
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.31142F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.68858F));
            mainControlsPanel.Controls.Add(customMenuStrip1, 0, 0);
            mainControlsPanel.Controls.Add(mainToolsPanel1, 1, 0);
            mainControlsPanel.Dock = DockStyle.Top;
            mainControlsPanel.Location = new Point(0, 0);
            mainControlsPanel.Name = "mainControlsPanel";
            mainControlsPanel.RowCount = 1;
            mainControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainControlsPanel.Size = new Size(616, 35);
            mainControlsPanel.TabIndex = 18;
            // 
            // additionalPanel
            // 
            additionalPanel.BackColor = Color.Black;
            additionalPanel.Dock = DockStyle.Fill;
            additionalPanel.Location = new Point(0, 35);
            additionalPanel.Name = "additionalPanel";
            additionalPanel.Size = new Size(616, 36);
            additionalPanel.TabIndex = 19;
            // 
            // TopPanel
            // 
            Controls.Add(additionalPanel);
            Controls.Add(mainControlsPanel);
            Name = "TopPanel";
            Size = new Size(616, 71);
            customMenuStrip1.ResumeLayout(false);
            customMenuStrip1.PerformLayout();
            mainControlsPanel.ResumeLayout(false);
            mainControlsPanel.PerformLayout();
            ResumeLayout(false);
        }

        private CustomMenuStrip.CustomMenuStrip customMenuStrip1;
        private ToolStripMenuItem testingggToolStripMenuItem;
        private ToolStripMenuItem dxfhdsafhToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem adsfhfdshToolStripMenuItem;
        private CustomMenuStrip.MainToolsPanel mainToolsPanel1;
        private Panel additionalPanel;
        private TableLayoutPanel mainControlsPanel;
    }
}
