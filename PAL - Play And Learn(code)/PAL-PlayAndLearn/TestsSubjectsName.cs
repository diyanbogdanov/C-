//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAL_PlayAndLearn
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestsSubjectsName
    {
        public TestsSubjectsName()
        {
            this.Tests = new HashSet<Test>();
        }
    
        public int ID { get; set; }
        public string TestsSubjectName { get; set; }
    
        public virtual ICollection<Test> Tests { get; set; }
    }
}