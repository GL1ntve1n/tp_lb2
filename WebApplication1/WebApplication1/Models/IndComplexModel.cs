using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class IndComplexModel
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("���")]
        public string Name { get; set; }

        [DisplayName("�������")]
        public string Surname { get; set; }

        [DisplayName("���� ��������")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("����� ��������")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DisplayName("����� �����")]
        public string ShiftNumber { get; set; }
    }

}