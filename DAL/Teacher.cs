using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
	/// <summary>
	/// 数据访问类:Teacher
	/// </summary>
	public partial class Teacher
	{
		public Teacher()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TID", "Teacher"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Teacher");
			strSql.Append(" where TID=@TID");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4)
			};
			parameters[0].Value = TID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ITCastOCSS.Model.Teacher model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Teacher(");
			strSql.Append("TNo,TName,TSex,TMajor,TPwd,TDepartment,TTitle,TIsAdmin)");
			strSql.Append(" values (");
			strSql.Append("@TNo,@TName,@TSex,@TMajor,@TPwd,@TDepartment,@TTitle,@TIsAdmin)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TNo", SqlDbType.Char,4),
					new SqlParameter("@TName", SqlDbType.NVarChar,8),
					new SqlParameter("@TSex", SqlDbType.NChar,1),
					new SqlParameter("@TMajor", SqlDbType.NVarChar,20),
					new SqlParameter("@TPwd", SqlDbType.NVarChar,20),
					new SqlParameter("@TDepartment", SqlDbType.NVarChar,20),
					new SqlParameter("@TTitle", SqlDbType.NVarChar,10),
					new SqlParameter("@TIsAdmin", SqlDbType.Int,4)};
			parameters[0].Value = model.TNo;
			parameters[1].Value = model.TName;
			parameters[2].Value = model.TSex;
			parameters[3].Value = model.TMajor;
			parameters[4].Value = model.TPwd;
			parameters[5].Value = model.TDepartment;
			parameters[6].Value = model.TTitle;
			parameters[7].Value = model.TIsAdmin;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ITCastOCSS.Model.Teacher model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Teacher set ");
			strSql.Append("TNo=@TNo,");
			strSql.Append("TName=@TName,");
			strSql.Append("TSex=@TSex,");
			strSql.Append("TMajor=@TMajor,");
			strSql.Append("TPwd=@TPwd,");
			strSql.Append("TDepartment=@TDepartment,");
			strSql.Append("TTitle=@TTitle,");
			strSql.Append("TIsAdmin=@TIsAdmin");
			strSql.Append(" where TID=@TID");
			SqlParameter[] parameters = {
					new SqlParameter("@TNo", SqlDbType.Char,4),
					new SqlParameter("@TName", SqlDbType.NVarChar,8),
					new SqlParameter("@TSex", SqlDbType.NChar,1),
					new SqlParameter("@TMajor", SqlDbType.NVarChar,20),
					new SqlParameter("@TPwd", SqlDbType.NVarChar,20),
					new SqlParameter("@TDepartment", SqlDbType.NVarChar,20),
					new SqlParameter("@TTitle", SqlDbType.NVarChar,10),
					new SqlParameter("@TIsAdmin", SqlDbType.Int,4),
					new SqlParameter("@TID", SqlDbType.Int,4)};
			parameters[0].Value = model.TNo;
			parameters[1].Value = model.TName;
			parameters[2].Value = model.TSex;
			parameters[3].Value = model.TMajor;
			parameters[4].Value = model.TPwd;
			parameters[5].Value = model.TDepartment;
			parameters[6].Value = model.TTitle;
			parameters[7].Value = model.TIsAdmin;
			parameters[8].Value = model.TID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int TID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Teacher ");
			strSql.Append(" where TID=@TID");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4)
			};
			parameters[0].Value = TID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string TIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Teacher ");
			strSql.Append(" where TID in ("+TIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public ITCastOCSS.Model.Teacher GetModel(int TID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TID,TNo,TName,TSex,TMajor,TPwd,TDepartment,TTitle,TIsAdmin from Teacher ");
			strSql.Append(" where TID=@TID");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4)
			};
			parameters[0].Value = TID;

			ITCastOCSS.Model.Teacher model=new ITCastOCSS.Model.Teacher();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public ITCastOCSS.Model.Teacher DataRowToModel(DataRow row)
		{
			ITCastOCSS.Model.Teacher model=new ITCastOCSS.Model.Teacher();
			if (row != null)
			{
				if(row["TID"]!=null && row["TID"].ToString()!="")
				{
					model.TID=int.Parse(row["TID"].ToString());
				}
				if(row["TNo"]!=null)
				{
					model.TNo=row["TNo"].ToString();
				}
				if(row["TName"]!=null)
				{
					model.TName=row["TName"].ToString();
				}
				if(row["TSex"]!=null)
				{
					model.TSex=row["TSex"].ToString();
				}
				if(row["TMajor"]!=null)
				{
					model.TMajor=row["TMajor"].ToString();
				}
				if(row["TPwd"]!=null)
				{
					model.TPwd=row["TPwd"].ToString();
				}
				if(row["TDepartment"]!=null)
				{
					model.TDepartment=row["TDepartment"].ToString();
				}
				if(row["TTitle"]!=null)
				{
					model.TTitle=row["TTitle"].ToString();
				}
				if(row["TIsAdmin"]!=null && row["TIsAdmin"].ToString()!="")
				{
					model.TIsAdmin=int.Parse(row["TIsAdmin"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TID,TNo,TName,TSex,TMajor,TPwd,TDepartment,TTitle,TIsAdmin ");
			strSql.Append(" FROM Teacher ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" TID,TNo,TName,TSex,TMajor,TPwd,TDepartment,TTitle,TIsAdmin ");
			strSql.Append(" FROM Teacher ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Teacher ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.TID desc");
			}
			strSql.Append(")AS Row, T.*  from Teacher T ");
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
			parameters[0].Value = "Teacher";
			parameters[1].Value = "TID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Teacher GetModel(string no)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TID,TNo,TName,TSex,TMajor,TPwd,TDepartment,TTitle,TIsAdmin from Teacher ");
            strSql.Append(" where TNo=@TNo");
            SqlParameter[] parameters = {
                    new SqlParameter("@TNo", SqlDbType.Char)
            };
            parameters[0].Value = no;

            ITCastOCSS.Model.Teacher model = new ITCastOCSS.Model.Teacher();
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
        #endregion  ExtensionMethod
    }
}

