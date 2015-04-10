/*Create a class Group with properties GroupNumber and DepartmentName.
Introduce a property GroupNumber in the Student class.
Extract all students from "Mathematics" department.
Use the Join operator.*/

namespace _07.StudentGroup
    {
    /// <summary>
    /// A class for group of students
    /// </summary>
    public class Group
        {
        /// <summary>
        /// Field of the Group class
        /// </summary>
        private int groupNumber;

        /// <summary>
        /// Field of the Group class
        /// </summary>
        private string departmentName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        /// <param name="groupNumber">the number of the group</param>
        /// <param name="departmentName">the name of the department</param>
        public Group(int groupNumber, string departmentName)
            {
            this.groupNumber = groupNumber;
            this.departmentName = departmentName;
            }

        /// <summary>
        /// Gets a property for the group number
        /// </summary>
        public int GroupNumber
            {
            get { return this.groupNumber; }
            }

        /// <summary>
        /// Gets a property for the department name
        /// </summary>
        public string DepartmentName
            {
            get { return this.departmentName; }
            }
        }
    }
