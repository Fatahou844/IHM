using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Interface_RADAR
{
    public class TriangleRadarItem : RadarItem
    {
        int _id;
        int _azimuth;
        int _range;
        int _width;
        int _height;
        DateTime _created = DateTime.Now;
        GraphicsPath _gp;

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public int Azimuth
        {
            get
            {
                return _azimuth;
            }
            set
            {
                _azimuth = value;
                while (_azimuth < 0)
                {
                    _azimuth += 360;
                }
                if (_azimuth >= 360)
                    _azimuth = _azimuth % 360;
            }
        }
        public int Range
        {
            get
            {
                return _range;
            }
            set
            {
                _range = value;
                if (_range > 90)
                    _range = 90;
                else if (_range < 0)
                    _range = 0;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
            }
        }
        public DateTime Created
        {
            get
            {
                return _created;
            }
        }

        public TriangleRadarItem(int id, int size, int az, int rg)
        {
            _id = id;
            _width = size;
            _height = size;
            _azimuth = az;
            _range = rg;
        }

        public void DrawItem(Radar radar, Graphics g)

        {
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Lime);
            Font drawFont_risk = new Font("Wide Latin", 14);
            SolidBrush drawBrush_risk = new SolidBrush(Color.Red);

            PointF cp = radar.AzRg2XY(_azimuth, _range);
            PointF _topLeft = new PointF(cp.X - ((float)_width / 2), cp.Y - ((float)_height / 2));

            PointF p1 = new PointF(((float)_topLeft.X + ((float)_width / 2F)), (float)_topLeft.Y);
            PointF p2 = new PointF((float)_topLeft.X, (float)_topLeft.Y + (float)_height);
            PointF p3 = new PointF((float)_topLeft.X + (float)_width, (float)_topLeft.Y + (float)_height);

            _gp = new GraphicsPath(FillMode.Winding);
            _gp.AddPolygon(new PointF[] { p1, p2, p3 });
            g.DrawString("V=10 m/s", drawFont, drawBrush, cp);

            g.FillPath(new SolidBrush(radar.CustomLineColor), _gp);

            // Zone à risque
            if ((decimal)(_range) <= 5)
            {
                g.DrawString("!", drawFont_risk, drawBrush_risk, _topLeft);
            }
            // Zone tolérable
            else if ((decimal)(_range) <= 15)
            {
                g.DrawString("└", drawFont_risk, drawBrush_risk, _topLeft);
            }
        }

        public int CompareTo(RadarItem item)
        {
            return 0;
        }
    }
}
