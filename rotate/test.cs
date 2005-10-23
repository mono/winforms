using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Test
{
  static Bitmap load(string name)
  {
    using (Stream stream = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.None))
      return (Bitmap)Bitmap.FromStream(stream);
  }

  static void Main()
  {
    foreach (string type_name in Enum.GetNames(typeof(RotateFlipType)))
    {
      RotateFlipType type = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), type_name);

      if (type_name != type.ToString())
        Console.WriteLine("- processing {0} ({1})...", type_name, type);
      else
        Console.WriteLine("- processing {0}...", type_name);

      Bitmap result = null;

      try
      {
        result = load("24bit.png");
        result.RotateFlip(type);
      }
      catch (Exception e)
      {
        Console.WriteLine("EXCEPTION (24-bit): {0}: {1}", e.GetType().Name, e.Message);
        if (result != null) try { result.Dispose(); } catch {}
        result = null;
      }

      if (result != null)
        result.Save("24bit_" + type_name + ".png", ImageFormat.Png);

      try { result.Dispose(); } catch {}

      try
      {
        Bitmap intermediate = load("24bit.png");
        result = new Bitmap(intermediate.Width, intermediate.Height, PixelFormat.Format16bppRgb565);
        using (Graphics g = Graphics.FromImage(result))
        {
          Rectangle bounds = new Rectangle(0, 0, result.Width, result.Height);
          g.DrawImage(intermediate, bounds, bounds, GraphicsUnit.Pixel);
        }

        result.RotateFlip(type);
      }
      catch (Exception e)
      {
        Console.WriteLine("EXCEPTION (16-bit): {0}: {1}", e.GetType().Name, e.Message);
        if (result != null) try { result.Dispose(); } catch {}
        result = null;
      }

      if (result != null)
        result.Save("16bit_" + type_name + ".png", ImageFormat.Png);

      try { result.Dispose(); } catch {}

      try
      {
        result = load("8bit.png");
        result.RotateFlip(type);
      }
      catch (Exception e)
      {
        Console.WriteLine("EXCEPTION (8-bit): {0}: {1}", e.GetType().Name, e.Message);
        if (result != null) try { result.Dispose(); } catch {}
        result = null;
      }

      if (result != null)
        result.Save("8bit_" + type_name + ".png", ImageFormat.Png);

      try { result.Dispose(); } catch {}
    }

    Console.WriteLine("done!");
  }
}
