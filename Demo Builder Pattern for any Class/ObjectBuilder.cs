using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Demo_Builder_Pattern_for_any_Class
{
    /*
    public class Director2
    {
        //public void ConstructObject(ObjectBuilder<T> builder)
        
    }
    public class ObjectBuilder<T>
    {
        public static ObjectBuilder<T> builder = new ObjectBuilder<T>();
        public DataTable data
        {
            get
            {
                FieldInfo[] fieldInfos = typeof(T).GetFields();
                DataTable _temp = new DataTable();
                foreach (FieldInfo fieldInfo in fieldInfos)
                {
                    _temp.Columns.Add(fieldInfo.Name);
                }
                return _temp;
            }
            set { }
        }
        public DataRow BuildPart(string FieldName, string Value)
        {
            DataRow row = data.NewRow();
            row[FieldName] = Value;
            
            return row;
        }
    }
    public class ConcreteBuilder
    {
        public DataRow rows = ObjectBuilder<T>.builder.data.NewRow();
        T ob = new T();
        public void BuildPart(string FieldName, string Value)
        {
            rows[FieldName] = Value;
        }
        public void AddRow( )
        {
            ObjectBuilder<T>.builder.data.Rows.Add(rows);

        }
    }

    */
}
