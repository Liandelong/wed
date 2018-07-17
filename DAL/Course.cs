using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
	/// <summary>
	/// 数据访问类:Course
	/// </summary>
	public partial class Course
	{
		public Course()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CID", "Course"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Course");
			strSql.Append(" where CID=@CID");
			SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4)
			};
			parameters[0].Value = CID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ITCastOCSS.Model.Course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Course(");
			strSql.Append("Description,Grade,Term,Credit,CName)");
			strSql.Append(" values (");
			strSql.Append("@Description,@Grade,@Term,@Credit,@CName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Grade", SqlDbType.NVarChar,10),
					new SqlParameter("@Term", SqlDbType.NVarChar,10),
					new SqlParameter("@Credit", SqlDbType.Int,4),
					new SqlParameter("@CName", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.Description;
			parameters[1].Value = model.Grade;
			parameters[2].Value = model.Term;
			parameters[3].Value = model.Credit;
			parameters[4].Value = model.CName;

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
		public bool Update(ITCastOCSS.Model.Course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Course set ");
			strSql.Append("Description=@Description,");
			strSql.Append("Grade=@Grade,");
			strSql.Append("Term=@Term,");
			strSql.Append("Credit=@Credit,");
			strSql.Append("CName=@CName");
			strSql.Append(" where CID=@CID");
			SqlParameter[] parameters = {
					new SqlParameter("@Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Grade", SqlDbType.NVarChar,10),
					new SqlParameter("@Term", SqlDbType.NVarChar,10),
					new SqlParameter("@Credit", SqlDbType.Int,4),
					new SqlParameter("@CName", SqlDbType.NVarChar,20),
					new SqlParameter("@CID", SqlDbType.Int,4)};
			parameters[0].Value = model.Description;
			parameters[1].Value = model.Grade;
			parameters[2].Value = model.Term;
			parameters[3].Value = model.Credit;
			parameters[4].Value = model.CName;
			parameters[5].Value = model.CID;

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
		public bool Delete(int CID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Course ");
			strSql.Append(" where CID=@CID");
			SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4)
			};
			parameters[0].Value = CID;

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
		public bool DeleteList(string CIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Course ");
			strSql.Append(" where CID in ("+CIDlist + ")  ");
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
		public ITCastOCSS.Model.Course GetModel(int CID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CID,Description,Grade,Term,Credit,CName from Course ");
			strSql.Append(" where CID=@CID");
			SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4)
			};
			parameters[0].Value = CID;

			ITCastOCSS.Model.Course model=new ITCastOCSS.Model.Course();
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
		public ITCastOCSS.Model.Course DataRowToModel(DataRow row)
		{
			ITCastOCSS.Model.Course model=new ITCastOCSS.Model.Course();
			if (row != null)
			{
				if(row["CID"]!=null && row["CID"].ToString()!="")
				{
					model.CID=int.Parse(row["CID"].ToString());
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["Grade"]!=null)
				{
					model.Grade=row["Grade"].ToString();
				}
				if(row["Term"]!=null)
				{
					model.Term=row["Term"].ToString();
				}
				if(row["Credit"]!=null && row["Credit"].ToString()!="")
				{
					model.Credit=int.Parse(row["Credit"].ToString());
				}
				if(row["CName"]!=null)
				{
					model.CName=row["CName"].ToString();
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
			strSql.Append("select CID,Description,Grade,Term,Credit,CName ");
			strSql.Append(" FROM Course ");
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
			strSql.Append(" CID,Description,Grade,Term,Credit,CName ");
			strSql.Append(" FROM Course ");
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
			strSql.Append("select count(1) FROM Course ");
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
				strSql.Append("order by T.CID desc");
			}
			strSql.Append(")AS Row, T.*  from Course T ");
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
			parameters[0].Value = "Course";
			parameters[1].Value = "CID";
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

