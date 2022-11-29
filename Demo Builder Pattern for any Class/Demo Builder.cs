using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Builder_Pattern_for_any_Class
{
    public class Demo_Builder
    {
        //public void CreateOb(KhoiTao build)
        //{
        //    build.Ketqua();
        //}
    }

    abstract class KhoiTao
    {
        public abstract void TaoPhanNho(string FieldName, string Value);
        public abstract Demo Ketqua();
    }
    class KhoiTao1: KhoiTao
    {
        private Demo _demo= new Demo();
        public override void TaoPhanNho(string FieldName,string Value)
        {
            _demo.GetType().GetField(FieldName).SetValue(_demo, Value);
        }
        public override Demo Ketqua()
        {
            return _demo;
        }

    }
    class KhoiTaoAll:Demo
    {
        private Type par = typeof(KhoiTaoAll).BaseType;
        private Demo _ob = new Demo();
        public  void TaoPhanNho(string FieldName, string Value)
        {
            this.GetType().GetField(FieldName).SetValue(_ob, Value);
        }
        public  Demo Ketqua()
        {
            return _ob;
        }
    }
    public class Demo 
    {
        public string Ten;
        public string Ho;
        public string Tuoi;
        public Demo() { }
        public override string ToString()
        {
            return Ho + " " + Ten + " " + Tuoi + " tuổi.";
        }
        public Demo BuildPart(string FieldName, string Value)
        {
            this.GetType().GetField(FieldName).SetValue(this, Value);

            return this;
        }
    }
}
