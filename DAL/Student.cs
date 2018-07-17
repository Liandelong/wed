using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
	/// <summary>
	/// 数据访问类:Student
	/// </summary>
	public partial class Student
	{
		public Student()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SID", "Student"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Student");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4)
			};
			parameters[0].Value = SID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ITCastOCSS.Model.Student model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Student(");
			strSql.Append("SNo,SName,SPwd,SSex,SClass,SType,SDepartment,SMajor,SMaxNum,SActualNum,SBirthday,SInTime,SGrade,SNote)");
			strSql.Append(" values (");
			strSql.Append("@SNo,@SName,@SPwd,@SSex,@SClass,@SType,@SDepartment,@SMajor,@SMaxNum,@SActualNum,@SBirthday,@SInTime,@SGrade,@SNote)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SNo", SqlDbType.Char,9),
					new SqlParameter("@SName", SqlDbType.NVarChar,8),
					new SqlParameter("@SPwd", SqlDbType.VarChar,20),
					new SqlParameter("@SSex", SqlDbType.NChar,1),
					new SqlParameter("@SClass", SqlDbType.VarChar,10),
					new SqlParameter("@SType", SqlDbType.VarChar,10),
					new SqlParameter("@SDepartment", SqlDbType.NVarChar,20),
					new SqlParameter("@SMajor", SqlDbType.NVarChar,20),
					new SqlParameter("@SMaxNum", SqlDbType.Int,4),
					new SqlParameter("@SActualNum", SqlDbType.Int,4),
					new SqlParameter("@SBirthday", SqlDbType.DateTime),
					new SqlParameter("@SInTime", SqlDbType.DateTime),
					new SqlParameter("@SGrade", SqlDbType.NVarChar,10),
					new SqlParameter("@SNote", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.SNo;
			parameters[1].Value = model.SName;
			parameters[2].Value = model.SPwd;
			parameters[3].Value = model.SSex;
			parameters[4].Value = model.SClass;
			parameters[5].Value = model.SType;
			parameters[6].Value = model.SDepartment;
			parameters[7].Value = model.SMajor;
			parameters[8].Value = model.SMaxNum;
			parameters[9].Value = model.SActualNum;
			parameters[10].Value = model.SBirthday;
			parameters[11].Value = model.SInTime;
			parameters[12].Value = model.SGrade;
			parameters[13].Value = model.SNote;

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
		public bool Update(ITCastOCSS.Model.Student model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Student set ");
			strSql.Append("SNo=@SNo,");
			strSql.Append("SName=@SName,");
			strSql.Append("SPwd=@SPwd,");
			strSql.Append("SSex=@SSex,");
			strSql.Append("SClass=@SClass,");
			strSql.Append("SType=@SType,");
			strSql.Append("SDepartment=@SDepartment,");
			strSql.Append("SMajor=@SMajor,");
			strSql.Append("SMaxNum=@SMaxNum,");
			strSql.Append("SActualNum=@SActualNum,");
			strSql.Append("SBirthday=@SBirthday,");
			strSql.Append("SInTime=@SInTime,");
			strSql.Append("SGrade=@SGrade,");
			strSql.Append("SNote=@SNote");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SNo", SqlDbType.Char,9),
					new SqlParameter("@SName", SqlDbType.NVarChar,8),
					new SqlParameter("@SPwd", SqlDbType.VarChar,20),
					new SqlParameter("@SSex", SqlDbType.NChar,1),
					new SqlParameter("@SClass", SqlDbType.VarChar,10),
					new SqlParameter("@SType", SqlDbType.VarChar,10),
					new SqlParameter("@SDepartment", SqlDbType.NVarChar,20),
					new SqlParameter("@SMajor", SqlDbType.NVarChar,20),
					new SqlParameter("@SMaxNum", SqlDbType.Int,4),
					new SqlParameter("@SActualNum", SqlDbType.Int,4),
					new SqlParameter("@SBirthday", SqlDbType.DateTime),
					new SqlParameter("@SInTime", SqlDbType.DateTime),
					new SqlParameter("@SGrade", SqlDbType.NVarChar,10),
					new SqlParameter("@SNote", SqlDbType.NVarChar,100),
					new SqlParameter("@SID", SqlDbType.Int,4)};
			parameters[0].Value = model.SNo;
			parameters[1].Value = model.SName;
			parameters[2].Value = model.SPwd;
			parameters[3].Value = model.SSex;
			parameters[4].Value = model.SClass;
			parameters[5].Value = model.SType;
			parameters[6].Value = model.SDepartment;
			parameters[7].Value = model.SMajor;
			parameters[8].Value = model.SMaxNum;
			parameters[9].Value = model.SActualNum;
			parameters[10].Value = model.SBirthday;
			parameters[11].Value = model.SInTime;
			parameters[12].Value = model.SGrade;
			parameters[13].Value = model.SNote;
			parameters[14].Value = model.SID;

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
		public bool Delete(int SID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Student ");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4)
			};
			parameters[0].Value = SID;

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
		public bool DeleteList(string SIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Student ");
			strSql.Append(" where SID in ("+SIDlist + ")  ");
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
		public ITCastOCSS.Model.Student GetModel(int SID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SID,SNo,SName,SPwd,SSex,SClass,SType,SDepartment,SMajor,SMaxNum,SActualNum,SBirthday,SInTime,SGrade,SNote from Student ");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4)
			};
			parameters[0].Value = SID;

			ITCastOCSS.Model.Student model=new ITCastOCSS.Model.Student();
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
		public ITCastOCSS.Model.Student DataRowToModel(DataRow row)
		{
			ITCastOCSS.Model.Student model=new ITCastOCSS.Model.Student();
			if (row != null)
			{
				if(row["SID"]!=null && row["SID"].ToString()!="")
				{
					model.SID=int.Parse(row["SID"].ToString());
				}
				if(row["SNo"]!=null)
				{
					model.SNo=row["SNo"].ToString();
				}
				if(row["SName"]!=null)
				{
					model.SName=row["SName"].ToString();
				}
				if(row["SPwd"]!=null)
				{
					model.SPwd=row["SPwd"].ToString();
				}
				if(row["SSex"]!=null)
				{
					model.SSex=row["SSex"].ToString();
				}
				if(row["SClass"]!=null)
				{
					model.SClass=row["SClass"].ToString();
				}
				if(row["SType"]!=null)
				{
					model.SType=row["SType"].ToString();
				}
				if(row["SDepartment"]!=null)
				{
					model.SDepartment=row["SDepartment"].ToString();
				}
				if(row["SMajor"]!=null)
				{
					model.SMajor=row["SMajor"].ToString();
				}
				if(row["SMaxNum"]!=null && row["SMaxNum"].ToString()!="")
				{
					model.SMaxNum=int.Parse(row["SMaxNum"].ToString());
				}
				if(row["SActualNum"]!=null && row["SActualNum"].ToString()!="")
				{
					model.SActualNum=int.Parse(row["SActualNum"].ToString());
				}
				if(row["SBirthday"]!=null && row["SBirthday"].ToString()!="")
				{
					model.SBirthday=DateTime.Parse(row["SBirthday"].ToString());
				}
				if(row["SInTime"]!=null && row["SInTime"].ToString()!="")
				{
					model.SInTime=DateTime.Parse(row["SInTime"].ToString());
				}
				if(row["SGrade"]!=null)
				{
					model.SGrade=row["SGrade"].ToString();
				}
				if(row["SNote"]!=null)
				{
					model.SNote=row["SNote"].ToString();
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
			strSql.Append("select SID,SNo,SName,SPwd,SSex,SClass,SType,SDepartment,SMajor,SMaxNum,SActualNum,SBirthday,SInTime,SGrade,SNote ");
			strSql.Append(" FROM Student ");
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
			strSql.Append(" SID,SNo,SName,SPwd,SSex,SClass,SType,SDepartment,SMajor,SMaxNum,SActualNum,SBirthday,SInTime,SGrade,SNote ");
			strSql.Append(" FROM Student ");
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
			strSql.Append("select count(1) FROM Student ");
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
				strSql.Append("order by T.SID desc");
			}
			strSql.Append(")AS Row, T.*  from Student T ");
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
			parameters[0].Value = "Student";
			parameters[1].Value = "SID";
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

