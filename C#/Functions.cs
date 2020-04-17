using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atractii_turistice
{
    class Functions
    {
        public static Bitmap _wholePicture, _background, _board;
        public static List<Piece> _pieces;
        public static int _targetSize = 200;
        public static int _numRow, _numCol, _rowHeight, _colWidth;
        public static Piece _movingPiece;
        public static Point _movingPoint;
        public static bool _gameOver = true;
        public static void LoadPicture(string filename, PictureBox puzzleImage, Form form)
        {
            try
            {
                using (var bm = new Bitmap(filename))
                {
                    _wholePicture = new Bitmap(bm.Width, bm.Height);
                    using (var gr = Graphics.FromImage(_wholePicture))
                    {
                        gr.DrawImage(bm, 0, 0, bm.Width, bm.Height);
                    }
                }
                _background = new Bitmap(_wholePicture.Width, _wholePicture.Height);
                _board = new Bitmap(_wholePicture.Width, _wholePicture.Height);
                puzzleImage.Size = _wholePicture.Size;
                puzzleImage.Image = _board;
                form.ClientSize = new Size(puzzleImage.Right + puzzleImage.Left, puzzleImage.Bottom + puzzleImage.Left);
                StartGame(puzzleImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void StartGame(PictureBox puzzleImage)
        {
            if (_wholePicture == null)
                return;
            _gameOver = false;
            _numRow = _wholePicture.Height / _targetSize;
            _rowHeight = _wholePicture.Height / _numRow;
            _numCol = _wholePicture.Width / _targetSize;
            _colWidth = _wholePicture.Width / _numCol;
            var rand = new Random();
            _pieces = new List<Piece>();
            for (int row = 0; row < _numRow; row++)
            {
                int hgt = _rowHeight;
                if (row == _numRow - 1)
                    hgt = _wholePicture.Height - row * _rowHeight;
                for (int col = 0; col < _numCol; col++)
                {
                    int wid = _colWidth;
                    if (col == _numCol - 1)
                        wid = _wholePicture.Width - col * _colWidth;
                    var rect = new Rectangle(col * _colWidth, row * _rowHeight, wid, hgt);
                    var new_piece = new Piece(_wholePicture, rect)
                    {
                        _currentLocation = new Rectangle(rand.Next(0, _wholePicture.Width - wid), rand.Next(0, _wholePicture.Height - hgt), wid, hgt)
                    };
                    _pieces.Add(new_piece);
                }
            }
            MakeBackground(puzzleImage);
            DrawBoard(puzzleImage);
        }
        public static void MakeBackground(PictureBox puzzleImage)
        {
            using (var gr = Graphics.FromImage(_background))
            {
                gr.Clear(puzzleImage.BackColor);
                using (var thick_pen = new Pen(Color.DarkGray, 4))
                {
                    for (int y = 0; y <= _wholePicture.Height; y += _rowHeight)
                    {
                        gr.DrawLine(thick_pen, 0, y, _wholePicture.Width, y);
                    }
                    gr.DrawLine(thick_pen, 0, _wholePicture.Height, _wholePicture.Width, _wholePicture.Height);
                    for (int x = 0; x <= _wholePicture.Width; x += _colWidth)
                    {
                        gr.DrawLine(thick_pen, x, 0, x, _wholePicture.Height);
                    }
                    gr.DrawLine(thick_pen, _wholePicture.Width, 0, _wholePicture.Width, _wholePicture.Height);
                }
                using (var white_pen = new Pen(Color.White, 3))
                {
                    using (var black_pen = new Pen(Color.Black, 3))
                    {
                        foreach (var piece in _pieces)
                        {
                            if (piece == _movingPiece)
                                continue;
                            gr.DrawImage(_wholePicture, piece._currentLocation, piece._homelocation, GraphicsUnit.Pixel);
                            if (_gameOver)
                                continue;
                            gr.DrawRectangle(piece.IsTHePieceHome()
                                ? white_pen
                                : black_pen, piece._currentLocation);
                        }
                    }
                }
            }
            puzzleImage.Visible = true;
            puzzleImage.Refresh();
        }
        public static void DrawBoard(PictureBox puzzleImage)
        {
            using (var gr = Graphics.FromImage(_board))
            {
                gr.DrawImage(_background, 0, 0, _background.Width, _background.Height);
                if (_movingPiece != null)
                {
                    gr.DrawImage(_wholePicture, _movingPiece._currentLocation, _movingPiece._homelocation, GraphicsUnit.Pixel);
                    using (var blue_pen = new Pen(Color.Blue, 4))
                    {
                        gr.DrawRectangle(blue_pen, _movingPiece._currentLocation);
                    }
                }
            }
            puzzleImage.Visible = true;
            puzzleImage.Refresh();
        }
    }
}
