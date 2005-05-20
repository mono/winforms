/*
 * CustomControl.cs - Sample program for Custom control creation.
 *
 * Copyright (C) 2003  Southern Storm Software, Pty Ltd.
 *
 * This program is free software, you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY, without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program, if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

public class MainForm : Form
{
	
	private MainForm()
	{
		SetStyle(ControlStyles.ResizeRedraw, true);
	}
	public static void Main(String[] args)
	{
		Form form = new MainForm();
		form.ClientSize = new Size(400, 330);
		form.Text = "Graphs app";
		GraphItem[] data=new GraphItem[] 
							{
								new GraphItem(0,0),
								new GraphItem(10,10),
								new GraphItem(20,35),
								new GraphItem(30,40),
								new GraphItem(60,80),
								new GraphItem(70,30),
								new GraphItem(75,50),
								new GraphItem(100,90)
							};
		Control ctrl = new GraphControl(data,0,0,320,320);
		ctrl.Show();
		ctrl.Location = new Point(10,10);
		form.Controls.Add(ctrl);
		Application.Run(form);
	}
}

/// <summary>
/// The visual points on the graph 
/// </summary>
public class GraphPoint: Control
{
	private bool active=false;
	private Color ActiveColor=Color.Red;
	private Color InactiveColor=Color.FromArgb(0x91,0x91,0x91);
	const int radius=5;
	private static Size offset=new Size(radius, radius);
	private Label label;

	internal void Draw(Graphics graphics)
	{
		if(!Visible) return;
		using(Brush brush=new SolidBrush(active ? ActiveColor : InactiveColor))
		{
			graphics.FillEllipse(brush, 0,0, 2*radius, 2*radius);
		}
	}

	protected override void OnPaint(PaintEventArgs args)
	{
		Draw(args.Graphics);
	}

	protected override void OnMouseEnter(EventArgs args)
	{
		active=true;
		label.Visible=true;
		using(Graphics graphics=CreateGraphics())
		{
			Draw(graphics);
		}
	}

	protected override void OnMouseLeave(EventArgs args)
	{
		active=false;
		label.Visible=false;
		using(Graphics graphics=CreateGraphics())
		{
			Draw(graphics);
		}
	}

	protected override Size DefaultSize
	{
		get
		{
			return new Size(2*radius,2*radius);
		}
	}

	public GraphPoint(Point pt, GraphItem item)
	{
		Visible=true;
		this.Location=pt-offset;
		label=new Label();
		label.Text=item.ToString();
		label.Visible=false;
		label.Width=50;
		label.ForeColor=Color.Blue;
		label.Location=this.Location+new Size(offset.Width + radius + 3, offset.Height - label.Height/2);
	}

	public Point Point
	{
		get
		{
			return (Location + offset);
		}
	}

	public Label Label
	{
		get
		{
			return label;
		}
	}
}

///<summary>
/// The actual graph control class which handles the grid control
///</summary>
public class GraphControl: Control
{
	private GraphPoint [] points =null;
	const int edge=300;
	Size offset;
	private ProgressBar bar;
	
	internal void Draw(Graphics graphics)
	{
		int x=offset.Width;
		int y=offset.Height;
		using(Pen pen=new Pen(Color.FromArgb(0xC0,0xC0,0xC0), 0.5f))
		{
			for(int i=0;i<edge;i+=(edge/10))
			{
				graphics.DrawLine(pen, x+0, y+i, x+edge, y+i);
				graphics.DrawLine(pen, x+i, y+0, x+i, y+edge);
			}
		}

		using(Pen pen=new Pen(Color.Black, 1.0f))
		{
			graphics.DrawLine(pen,x+0,y+edge,x+edge,y+edge);
			graphics.DrawLine(pen,x+edge,y+edge,x+edge,y+0);
			graphics.DrawLine(pen,x,y,x,y+edge);
			graphics.DrawLine(pen,x,y,x+edge,y);
			for(int i=0;i<=edge;i+=(edge/10))
			{
				graphics.DrawLine(pen, x+0,y+i,x-4,y+i);
				graphics.DrawLine(pen, x+edge,y+i,x+edge+4,y+i);
				graphics.DrawLine(pen, x+i,y+edge,x+i,y+edge+4);
				graphics.DrawLine(pen, x+i,y,x+i,y-4);
			}
		}
		
		using(Pen pen=new Pen(Color.Red, 0.2f))
		{
			for(int i=1;i<points.Length;i++)
			{
				graphics.DrawLine(pen,points[i-1].Point,
									points[i].Point);
			}
		}

		using(Font font = new Font("Arial", 12))
		{
			using(Brush brush = new SolidBrush(Color.Black))
			{
				graphics.DrawString("Mouse Over Demo", font, brush, x+10,y+10);
			}
		}
	}

	protected override Size DefaultSize
	{
		get
		{
			return new Size(edge+20,edge+50);
		}
	}

	protected override void OnPaint(PaintEventArgs args)
	{
		Draw(args.Graphics);
	}
	
	protected override void OnMouseMove(MouseEventArgs e)
	{
		this.bar.Value=e.X;
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		this.bar.Value = this.bar.Minimum;
	}

	public GraphControl(GraphItem[] dataset,int left,int top,int right, int bottom) : base("GraphControl",left,top,right,bottom)
	{
		this.points=new GraphPoint[dataset.Length];
		offset=new Size(5,2);
		for(int i=0;i<dataset.Length;i++)
		{
			Point point=new Point();
			point.X=(dataset[i].X * (edge/100));
			point.Y=edge-(dataset[i].Y * (edge/100));
			point=point+offset;
			points[i]=new GraphPoint(point,dataset[i]);
			this.Controls.Add(points[i]);
			this.Controls.Add(points[i].Label);
		}
		
		bar=new ProgressBar();
		bar.Size=new Size(edge+4,16);
		bar.Location=new Point(3,edge+5);
		this.Controls.Add(bar);
		this.bar.Maximum=this.Right;
		this.bar.Minimum=this.Left;
		this.bar.Step=(edge/10);
	}
}

public struct GraphItem
{
	int x;
	int y;
	public GraphItem(int x, int y)
	{
		this.x=x;
		this.y=y;
	}
	public int X
	{
		get { return this.x; }
	}
	public int Y
	{
		get { return this.y; }
	}
	public override String ToString()
	{
		return  "("+x+","+y+")";
	}
}


