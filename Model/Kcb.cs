using System;
namespace ITCastOCSS.Model
{
    /// <summary>
    /// Kcb:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Kcb
    {
        public Kcb()
        { }
        #region Model
        private string _cname;
        private string _grade;
        private string _week;
        private string _timeperiod;
        private int? _maxnum;
        private int? _actualnum;
        private string _tno;
        private string _tname;
        private int _tid;
        private int _cid;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string CName
        {
            set { _cname = value; }
            get { return _cname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Week
        {
            set { _week = value; }
            get { return _week; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Timeperiod
        {
            set { _timeperiod = value; }
            get { return _timeperiod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MaxNum
        {
            set { _maxnum = value; }
            get { return _maxnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ActualNum
        {
            set { _actualnum = value; }
            get { return _actualnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TNo
        {
            set { _tno = value; }
            get { return _tno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TName
        {
            set { _tname = value; }
            get { return _tname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TID
        {
            set { _tid = value; }
            get { return _tid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CID
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion Model

    }
}

