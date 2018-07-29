using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
    /// <summary>
    /// 数据访问类:Xuanke
    /// </summary>
    public partial class Xuanke
    {
        public Xuanke()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Xuanke");
            strSql.Append(" where Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and ID=@ID and TID=@TID and CID=@CID and TName=@TName and Credit=@Credit and CName=@CName and Term=@Term and Grade=@Grade ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Term", SqlDbType.NVarChar,10),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10)           };
            parameters[0].Value = Week;
            parameters[1].Value = Timeperiod;
            parameters[2].Value = Place;
            parameters[3].Value = MaxNum;
            parameters[4].Value = ActualNum;
            parameters[5].Value = ID;
            parameters[6].Value = TID;
            parameters[7].Value = CID;
            parameters[8].Value = TName;
            parameters[9].Value = Credit;
            parameters[10].Value = CName;
            parameters[11].Value = Term;
            parameters[12].Value = Grade;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ITCastOCSS.Model.Xuanke model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Xuanke(");
            strSql.Append("Week,Timeperiod,Place,MaxNum,ActualNum,ID,TID,CID,TName,Credit,CName,Term,Grade)");
            strSql.Append(" values (");
            strSql.Append("@Week,@Timeperiod,@Place,@MaxNum,@ActualNum,@ID,@TID,@CID,@TName,@Credit,@CName,@Term,@Grade)");
            SqlParameter[] parameters = {
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Term", SqlDbType.NVarChar,10),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.Week;
            parameters[1].Value = model.Timeperiod;
            parameters[2].Value = model.Place;
            parameters[3].Value = model.MaxNum;
            parameters[4].Value = model.ActualNum;
            parameters[5].Value = model.ID;
            parameters[6].Value = model.TID;
            parameters[7].Value = model.CID;
            parameters[8].Value = model.TName;
            parameters[9].Value = model.Credit;
            parameters[10].Value = model.CName;
            parameters[11].Value = model.Term;
            parameters[12].Value = model.Grade;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ITCastOCSS.Model.Xuanke model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Xuanke set ");
            strSql.Append("Week=@Week,");
            strSql.Append("Timeperiod=@Timeperiod,");
            strSql.Append("Place=@Place,");
            strSql.Append("MaxNum=@MaxNum,");
            strSql.Append("ActualNum=@ActualNum,");
            strSql.Append("ID=@ID,");
            strSql.Append("TID=@TID,");
            strSql.Append("CID=@CID,");
            strSql.Append("TName=@TName,");
            strSql.Append("Credit=@Credit,");
            strSql.Append("CName=@CName,");
            strSql.Append("Term=@Term,");
            strSql.Append("Grade=@Grade");
            strSql.Append(" where Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and ID=@ID and TID=@TID and CID=@CID and TName=@TName and Credit=@Credit and CName=@CName and Term=@Term and Grade=@Grade ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Term", SqlDbType.NVarChar,10),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.Week;
            parameters[1].Value = model.Timeperiod;
            parameters[2].Value = model.Place;
            parameters[3].Value = model.MaxNum;
            parameters[4].Value = model.ActualNum;
            parameters[5].Value = model.ID;
            parameters[6].Value = model.TID;
            parameters[7].Value = model.CID;
            parameters[8].Value = model.TName;
            parameters[9].Value = model.Credit;
            parameters[10].Value = model.CName;
            parameters[11].Value = model.Term;
            parameters[12].Value = model.Grade;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Xuanke ");
            strSql.Append(" where Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and ID=@ID and TID=@TID and CID=@CID and TName=@TName and Credit=@Credit and CName=@CName and Term=@Term and Grade=@Grade ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Term", SqlDbType.NVarChar,10),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10)           };
            parameters[0].Value = Week;
            parameters[1].Value = Timeperiod;
            parameters[2].Value = Place;
            parameters[3].Value = MaxNum;
            parameters[4].Value = ActualNum;
            parameters[5].Value = ID;
            parameters[6].Value = TID;
            parameters[7].Value = CID;
            parameters[8].Value = TName;
            parameters[9].Value = Credit;
            parameters[10].Value = CName;
            parameters[11].Value = Term;
            parameters[12].Value = Grade;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Xuanke GetModel(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Week,Timeperiod,Place,MaxNum,ActualNum,ID,TID,CID,TName,Credit,CName,Term,Grade from Xuanke ");
            strSql.Append(" where Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and ID=@ID and TID=@TID and CID=@CID and TName=@TName and Credit=@Credit and CName=@CName and Term=@Term and Grade=@Grade ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Term", SqlDbType.NVarChar,10),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10)           };
            parameters[0].Value = Week;
            parameters[1].Value = Timeperiod;
            parameters[2].Value = Place;
            parameters[3].Value = MaxNum;
            parameters[4].Value = ActualNum;
            parameters[5].Value = ID;
            parameters[6].Value = TID;
            parameters[7].Value = CID;
            parameters[8].Value = TName;
            parameters[9].Value = Credit;
            parameters[10].Value = CName;
            parameters[11].Value = Term;
            parameters[12].Value = Grade;

            ITCastOCSS.Model.Xuanke model = new ITCastOCSS.Model.Xuanke();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Xuanke DataRowToModel(DataRow row)
        {
            ITCastOCSS.Model.Xuanke model = new ITCastOCSS.Model.Xuanke();
            if (row != null)
            {
                if (row["Week"] != null)
                {
                    model.Week = row["Week"].ToString();
                }
                if (row["Timeperiod"] != null)
                {
                    model.Timeperiod = row["Timeperiod"].ToString();
                }
                if (row["Place"] != null)
                {
                    model.Place = row["Place"].ToString();
                }
                if (row["MaxNum"] != null && row["MaxNum"].ToString() != "")
                {
                    model.MaxNum = int.Parse(row["MaxNum"].ToString());
                }
                if (row["ActualNum"] != null && row["ActualNum"].ToString() != "")
                {
                    model.ActualNum = int.Parse(row["ActualNum"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["TID"] != null && row["TID"].ToString() != "")
                {
                    model.TID = int.Parse(row["TID"].ToString());
                }
                if (row["CID"] != null && row["CID"].ToString() != "")
                {
                    model.CID = int.Parse(row["CID"].ToString());
                }
                if (row["TName"] != null)
                {
                    model.TName = row["TName"].ToString();
                }
                if (row["Credit"] != null && row["Credit"].ToString() != "")
                {
                    model.Credit = int.Parse(row["Credit"].ToString());
                }
                if (row["CName"] != null)
                {
                    model.CName = row["CName"].ToString();
                }
                if (row["Term"] != null)
                {
                    model.Term = row["Term"].ToString();
                }
                if (row["Grade"] != null)
                {
                    model.Grade = row["Grade"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Week,Timeperiod,Place,MaxNum,ActualNum,ID,TID,CID,TName,Credit,CName,Term,Grade ");
            strSql.Append(" FROM Xuanke ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Week,Timeperiod,Place,MaxNum,ActualNum,ID,TID,CID,TName,Credit,CName,Term,Grade ");
            strSql.Append(" FROM Xuanke ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Xuanke ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Grade desc");
            }
            strSql.Append(")AS Row, T.*  from Xuanke T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Xuanke";
			parameters[1].Value = "Grade";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

