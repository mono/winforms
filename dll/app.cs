using System;

namespace TestDllMono
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class TestDllForm
    {
        public TestDllForm()
        {
            TestForm  tForm = new TestForm();
            tForm.ShowDialog() ;

            // TODO: Add constructor logic here
            //
        }

	    static void Main() {
		TestDllForm dll;

		dll = new TestDllForm();
	    }
    }
}
