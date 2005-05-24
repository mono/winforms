//

using System;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		static int		test_no		= 1;
		static int		failed		= 0;
		static int		failed_expected = 0;
		static int		debug		= 0;
		static int		verbose		= 0;
		static bool		visual		= false;
		static bool		exception	= false;

		static Control		active;

		public void CheckConvert(int expect_from, int expect_to, TypeConverter conv, Type type) {
			int from_count	 = 0;
			int to_count	 = 0;

			foreach (Type t in typeof(int).Assembly.GetTypes ()) {
				if (conv.CanConvertFrom(null, t)) {
					from_count++;
					if (debug > 0) {
						Console.WriteLine("{0}: Conversion from {1} supported", conv.ToString(), t.ToString());
					}
				}

				if (conv.CanConvertTo(null, t)) {
					to_count++;
					if (debug > 0) {
						Console.WriteLine("{0}: Conversion to {1} supported", conv.ToString(), t.ToString());
					}
				}
			}

#if not
			foreach (Type t in type.Assembly.GetTypes ()) {
				if (conv.CanConvertFrom(null, t)) {
					from_count++;
					if (debug > 0) {
						Console.WriteLine("{0}: Conversion from {1} supported", conv.ToString(), t.ToString());
					}
				}

				if (conv.CanConvertTo(null, t)) {
					to_count++;
					if (debug > 0) {
						Console.WriteLine("{0}: Conversion to {1} supported", conv.ToString(), t.ToString());
					}
				}
			}
#endif

			if (from_count != expect_from) {
				if (verbose > 0) {
					Console.WriteLine("{0}: ConvertFrom expected {1}, returned {2}", conv.ToString(), expect_from, from_count);
				}
				failed++;
			}

			if (to_count != expect_to) {
				if (verbose > 0) {
					Console.WriteLine("{0}: ConvertTo expected {1}, returned {2}", conv.ToString(), expect_to, to_count);
				}
				failed++;
			}

		}

		public void CheckConversion(object check, object expect, TypeConverter conv, Type type) {
			CheckConversion(check, expect, conv, type, true, true, CultureInfo.InvariantCulture);
			CheckConversion(check, expect, conv, type, true, true, CultureInfo.CreateSpecificCulture("de-de"));
		}


		public void CheckConversion(object check, object expect, TypeConverter conv, Type type, bool test_from, bool test_to) {
			CheckConversion(check, expect, conv, type, test_from, test_to, CultureInfo.InvariantCulture);
			CheckConversion(check, expect, conv, type, test_from, test_to, CultureInfo.CreateSpecificCulture("de-de"));
		}
		public void CheckConversion(object check, object expect, TypeConverter conv, Type type, CultureInfo culture) {
			CheckConversion(check, expect, conv, type, true, true, culture);
		}

		public void CheckConversion(object check, object expect, TypeConverter conv, Type type, bool test_from, bool test_to, CultureInfo culture) {
			object obj;
			object result;

			obj = check;

			if (debug > 0) {
				Console.WriteLine("{0}: CheckConversion, checking {1}({2}) <-> {3}({4})", conv.ToString(), check.GetType().ToString(), check.ToString(), type.ToString(), expect != null ? expect.ToString() : "null");
			}

			if (test_to) {
				obj = conv.ConvertTo(null, culture, check, type);

				if (obj == null) {
					if (expect != null) {
						failed++;
						Console.WriteLine("{0}: ConvertTo failed, type {1}, expected {2}, got null", conv.ToString(), type.ToString(), expect.ToString());
					}
					return;
				}

				// Intermediate verification
				if (expect != null && !obj.Equals(expect)) {
					failed++;
					if (verbose > 0) {
						Console.WriteLine("{0}: ConvertTo failed, type {1}, expected {2}, got {3}", conv.ToString(), type.ToString(), expect.ToString(), obj.ToString());
					}
				}

				if (debug > 1) {
					Console.WriteLine("{0}: CheckConversion, ConvertTo result: '{1}')", conv.ToString(), obj);
				}
			}


			if (test_from) {
				result = conv.ConvertFrom(null, culture, obj);

				if (test_to) {
					// Roundtrip check
					if (!check.Equals(result)) {
						failed++;
						if (verbose > 0) {
							Console.WriteLine("{0}: ConvertTo/ConvertFrom roundtrip failed, type {1}", conv.ToString(), type.ToString());
						}
					}

				} else {
					if (!expect.Equals(result)) {
						failed++;
						if (verbose > 0) {
							Console.WriteLine("{0}: ConvertFrom failed, type {1}", conv.ToString(), type.ToString());
						}
					}
				}

				if (debug > 1) {
					Console.WriteLine("{0}: CheckConversion, ConvertFrom result: '{1}')", conv.ToString(), result);
				}
			}
		}

		public void CheckStandardValues(object[] expected, TypeConverter conv) {
			TypeConverter.StandardValuesCollection	values;

			values = conv.GetStandardValues(null);

			if (values == null && expected != null) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: GetStandardValues expected {0} values, got null", conv.ToString(), expected.Length);
				}
				return;
			}

			if (values != null && expected == null) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: GetStandardValues expected no values, got {1} values", conv.ToString(), values.Count);
				}
				return;
			}

			if (values != null) {
				if (values.Count != expected.Length) {
					if (verbose > 0) {
						Console.WriteLine("{0} GetStandardValues expected {1} values, returned {2}", conv.ToString(), expected.Length, values.Count);
					}
					failed++;
				}

				if (debug > 0) {
					Console.WriteLine("{0} Got {1} standard values", conv.ToString(), values.Count);
				}

				for (int i = 0; i < Math.Min(values.Count, expected.Length); i++) {
					if (debug > 0) {
						Console.WriteLine("{0}: Index {1:2} expecting:{2}, returned {3}", conv.ToString(), i, expected[i], values[i]);
					}

					if (!expected[i].Equals(values[i].ToString())) {
						if (verbose > 0) {
							Console.WriteLine("{0}: GetStandardValues Index {1} values don't match ({2} != {3})", conv.ToString(), i, expected[i], values[i]);
						}
						failed++;

					}
				}
			}
		}

		public void CheckStandardValuesExclusive(bool expect, TypeConverter conv) {
			bool result;

			result = conv.GetStandardValuesExclusive(null);

			if (result != expect) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: GetStandardValuesExclusive expected {1}, returned {2}", conv.ToString(), expect, result);
				}
			}
		}

		public void CheckStandardValuesSupported(bool expect, TypeConverter conv) {
			bool result;

			result = conv.GetStandardValuesSupported(null);

			if (result != expect) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: GetStandardValuesSupported expected {1}, returned {2}", conv.ToString(), expect, result);
				}
			}
		}

		public void TestKeysConverter() {
			KeysConverter	key_conv;
			Keys[]		keys;
			string[]	expected = new string [] {
						"Alt", "Back", "Control", "Delete", "End", "Enter", "F1", "F10", "F11", "F12", "F2",
						"F3", "F4", "F5", "F6", "F7", "F8", "F9", "Home", "Insert", "Next", "Prior", "Shift" };


			// Keys.Modifiers doesn't round-trip
			failed_expected += 2;	// Once for each culture

			key_conv = new KeysConverter();

			CheckConvert(1, 1, key_conv, typeof(Keys));

			keys = (Keys[])Enum.GetValues(typeof(Keys));
			for (int i = 0; i < keys.Length; i++) {
				CheckConversion(keys[i], null, key_conv, typeof(string));
			}
			CheckConversion(Keys.Shift | Keys.Alt | Keys.Control, "Ctrl+Alt+Shift+None", key_conv, typeof(string));
			CheckConversion(Keys.Shift | Keys.Alt | Keys.Control | Keys.F4, "Ctrl+Alt+Shift+F4", key_conv, typeof(string));
			CheckConversion(Keys.Shift | Keys.F4, "Shift+F4", key_conv, typeof(string));
			CheckConversion(Keys.ControlKey, "ControlKey", key_conv, typeof(string));

			CheckStandardValues(expected, key_conv);
			CheckStandardValuesSupported(true, key_conv);
			CheckStandardValuesExclusive(false, key_conv);
		}

		public void TestOpacityConverter() {
			OpacityConverter	conv;

			conv = new OpacityConverter();

			CheckConvert(1, 1, conv, typeof(double));

			CheckConversion(1.0, "100%", conv, typeof(string));
			CheckConversion(0.5, "50%", conv, typeof(string));
			CheckConversion(0.0, "0%", conv, typeof(string));
		}

		public void TestSelectionRangeConverter() {
			SelectionRangeConverter	conv;
			SelectionRange		sel;
			DateTime		start;
			DateTime		end;

			start = new DateTime(1969, 2, 1, 18, 0, 0, 0);
			end = new DateTime(1977, 5, 27, 0, 0, 0, 0);

			conv = new SelectionRangeConverter();
			sel = new SelectionRange(start, end);

			CheckConvert(1, 1, conv, typeof(SelectionRange));
			CheckConversion(sel, "1969-02-01, 1977-05-27", conv, typeof(string), CultureInfo.InvariantCulture);
			CheckConversion(sel, "01.02.1969; 27.05.1977", conv, typeof(string), CultureInfo.CreateSpecificCulture("de-de"));
		}

		public void TestDataGridPreferredColumnWidthTypeConverter() {
			DataGridPreferredColumnWidthTypeConverter conv;
			int	val;

			conv = new DataGridPreferredColumnWidthTypeConverter();

			CheckConvert(2, 1, conv, typeof(int));

			CheckConversion(-1, "AutoColumnResize (-1)", conv, typeof(string));
			CheckConversion(0, "0", conv, typeof(string));
			CheckConversion(1, "1", conv, typeof(string));

			CheckConversion("AutoColumnResize (-1)", -1, conv, typeof(int), true, false);
			CheckConversion("0", 0, conv, typeof(int), true, false);
			CheckConversion("1", 1, conv, typeof(int), true, false);
		}

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "SWF Converters Test App";

			TestKeysConverter();
			TestOpacityConverter();
			TestSelectionRangeConverter();
			TestDataGridPreferredColumnWidthTypeConverter();

			if (visual) {
				if (failed != failed_expected) {
					MessageBox.Show("All Tests Passed!", "Success");
				} else {
					MessageBox.Show(failed + "tests failed, only expected " + failed_expected + "; check the log", "Failure");
				}
			}
		}		
		
		public static int Main(string[] args) {
			if (args.Length > 0) {
				for (int i=0; i< args.Length; i++) {
					if ((args[i] == "-d") || (args[i] == "--debug")) {
						debug++;
						continue;
					}

					if ((args[i] == "-v") || (args[i] == "--verbose")) {
						verbose++;
						continue;
					}

					if ((args[i] == "-g") || (args[i] == "--gui")) {
						visual = true;
						continue;
					}

					if ((args[i] == "-e") || (args[i] == "--exception")) {
						exception = true;
						continue;
					}

					if ((args[i] == "-?") || (args[i] == "-h") || (args[i] == "--help")) {
						Console.WriteLine("Usage: <cmd> [-d | --debug] [-v | --verbose] [-g | --gui] [e | --exception]");
						return 0;
					}
				}
			}
			main_window = new MainWindow();
			active = main_window;

			// We don't want to run it, tests are already complete
			if (visual) {
				Application.Run(main_window);
			}

			if (failed == 0) {
				return 0;
			}

			return failed;
		}
	}
}
