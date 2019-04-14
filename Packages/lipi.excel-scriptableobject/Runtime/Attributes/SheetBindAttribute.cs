using System;

namespace ExcelScriptableObject
{
    public class ExcelBindAttribute : Attribute
    {
        public string ExcelName;
        public GenerateType GenType;
        public int HeadRow = 1;
        public int StartRow = 2;
        public string Key = "ID";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="excelName">�ļ���.���� ��ʽ, �ļ���������·���ͺ�׺</param>
        /// <param name="genType">excel��ÿ�ж�Ӧһ��so�ļ����������Ӧһ��so</param>
        public ExcelBindAttribute(string excelName, GenerateType genType = GenerateType.Row)
        {
            ExcelName = excelName;
            GenType = genType;
        }
    }

    public enum GenerateType
    {
        Row,
        Sheet
    }
}
