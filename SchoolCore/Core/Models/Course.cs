﻿using SchoolCore.Application.enumsType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolCore.Core.Models
{      
      /// <summary>
      /// 课程
      /// </summary>
    public class Course
    {
        //不是自动生成，不用管主件，
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName ("课程编号")]
        public int CourseId { get; set; }
        [DisplayName("课程名称")]
        [StringLength(50, MinimumLength = 2)]
        public String Title { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        [DisplayName("学分")]
        [Range(0, 5)]
        public int Credits { get; set; }
        /// <summary>
        /// 课程成绩
        /// </summary>
        [DisplayName("课程成绩")]      
        public CourseGrade Grade { get; set; }
        /// <summary>
        /// 部门id
        /// </summary>
        public int DepartmentId { get; set; }
        [DisplayName("部门名称")]
        public Department Department { get; set; }
        public ICollection<CourseAssignment> CourseAssignment { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
