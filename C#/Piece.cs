using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Atractii_turistice
{
    class Piece
    {
        public Bitmap _picture;
        public Rectangle _homelocation, _currentLocation;
        public Piece(Bitmap _newPicture, Rectangle _newHomeLocation)
        {
            _picture = _newPicture;
            _homelocation = _newHomeLocation;
        }
        public bool Contains(Point _point)
        {
            return _currentLocation.Contains(_point);
        }
        public bool IsThePieceCloseToHome()
        {
            if ((Math.Abs(_currentLocation.X - _homelocation.X) >= 20) || (Math.Abs(_currentLocation.Y - _homelocation.Y) >= 20))
                return false;
            _currentLocation = _homelocation;
            return true;
        }
        public bool IsTHePieceHome()
        {
            return _homelocation.Equals(_currentLocation);
        }
    }
}
