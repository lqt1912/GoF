using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Phương tiện giao thông 
    /// </summary>
    public class PhuongTien
    {
        /// <summary>
        /// Loại phương tiện 
        /// </summary>
        private string _loaiPhuongTien;
        public PhuongTien(string loaiPhuongTien)
        {
            _loaiPhuongTien = loaiPhuongTien;
        }


        /// <summary>
        /// Thành phần của phương tiện 
        /// </summary>
        private Dictionary<string, string> _thanhPhan = new Dictionary<string, string>();


        /// <summary>
        /// Hàm Get giá trị thành phần theo key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                return _thanhPhan[key];
            }
            set
            {
                _thanhPhan[key] = value;
            }
        }


        /// <summary>
        /// Hàm show của phương tiện, bao gồm show loại phương tiện và các thành phần của nó 
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\n ______________________");
            Console.WriteLine("Loại phương tiện: {0}", this._loaiPhuongTien);

            foreach (var thanhPhan in _thanhPhan)
            {
                Console.WriteLine("{0} : {1}", thanhPhan.Key, thanhPhan.Value);
            }
        }
    }
}
