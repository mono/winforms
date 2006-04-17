using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Text;

namespace ImageTest {
	public class Tester {
		public Tester() {
		}

		[Flags]
		public enum ImageFlags {
			None			= 0,
			Scalable		= 1,
			HasAlpha		= 2,
			HasTranslucent		= 4,
			PartiallyScalable	= 8,
			ColorSpaceRGB		= 16,
			ColorSpaceCMYK		= 32,
			ColorSpaceGRAY		= 64,
			ColorSpaceYCBCR		= 128,
			ColorSpaceYCCK		= 256,
			HasRealDPI		= 4096,
			HasRealPixelSize	= 8192,
			ReadOnly		= 65536,
			Caching			= 131072
		}

		public enum PropertyTagType {
			Byte		= 1,
			ASCII		= 2,
			Short		= 3,
			Long		= 4,
			Rational	= 5,
			Undefined	= 7,
			SLONG		= 9,
			SRational	= 10
		}

		public enum PropertyTag {
			ExifIFD             		= 0x8769,
			GpsIFD              		= 0x8825,

			NewSubfileType      		= 0x00FE,
			SubfileType         		= 0x00FF,
			ImageWidth          		= 0x0100,
			ImageHeight         		= 0x0101,
			BitsPerSample       		= 0x0102,
			Compression         		= 0x0103,
			PhotometricInterp   		= 0x0106,
			ThreshHolding       		= 0x0107,
			CellWidth           		= 0x0108,
			CellHeight          		= 0x0109,
			FillOrder           		= 0x010A,
			DocumentName        		= 0x010D,
			ImageDescription    		= 0x010E,
			EquipMake           		= 0x010F,
			EquipModel          		= 0x0110,
			StripOffsets        		= 0x0111,
			Orientation         		= 0x0112,
			SamplesPerPixel     		= 0x0115,
			RowsPerStrip        		= 0x0116,
			StripBytesCount     		= 0x0117,
			MinSampleValue      		= 0x0118,
			MaxSampleValue      		= 0x0119,
			XResolution         		= 0x011A,
			YResolution         		= 0x011B,
			PlanarConfig        		= 0x011C,
			PageName            		= 0x011D,
			XPosition           		= 0x011E,
			YPosition           		= 0x011F,
			FreeOffset          		= 0x0120,
			FreeByteCounts      		= 0x0121,
			GrayResponseUnit    		= 0x0122,
			GrayResponseCurve   		= 0x0123,
			T4Option            		= 0x0124,
			T6Option            		= 0x0125,
			ResolutionUnit      		= 0x0128,
			PageNumber          		= 0x0129,
			TransferFuncition   		= 0x012D,
			SoftwareUsed        		= 0x0131,
			DateTime            		= 0x0132,
			Artist              		= 0x013B,
			HostComputer        		= 0x013C,
			Predictor           		= 0x013D,
			WhitePoint          		= 0x013E,
			PrimaryChromaticities		= 0x013F,
			ColorMap            		= 0x0140,
			HalftoneHints       		= 0x0141,
			TileWidth           		= 0x0142,
			TileLength          		= 0x0143,
			TileOffset          		= 0x0144,
			TileByteCounts      		= 0x0145,
			InkSet              		= 0x014C,
			InkNames            		= 0x014D,
			NumberOfInks        		= 0x014E,
			DotRange            		= 0x0150,
			TargetPrinter       		= 0x0151,
			ExtraSamples        		= 0x0152,
			SampleFormat        		= 0x0153,
			SMinSampleValue     		= 0x0154,
			SMaxSampleValue     		= 0x0155,
			TransferRange       		= 0x0156,

			JPEGProc            		= 0x0200,
			JPEGInterFormat     		= 0x0201,
			JPEGInterLength     		= 0x0202,
			JPEGRestartInterval 		= 0x0203,
			JPEGLosslessPredictors		= 0x0205,
			JPEGPointTransforms		= 0x0206,
			JPEGQTables         		= 0x0207,
			JPEGDCTables        		= 0x0208,
			JPEGACTables        		= 0x0209,

			YCbCrCoefficients   		= 0x0211,
			YCbCrSubsampling    		= 0x0212,
			YCbCrPositioning    		= 0x0213,
			REFBlackWhite       		= 0x0214,

			ICCProfile          		= 0x8773,
			
			Gamma               		= 0x0301,
			ICCProfileDescriptor		= 0x0302,
			SRGBRenderingIntent 		= 0x0303,

			ImageTitle          		= 0x0320,
			Copyright           		= 0x8298,

			// Other tags (Adobe Image Info, etc)
			ResolutionXUnit		= 0x5001,
			ResolutionYUnit           	= 0x5002,
			ResolutionXLengthUnit     	= 0x5003,
			ResolutionYLengthUnit     	= 0x5004,
			PrintFlags                	= 0x5005,
			PrintFlagsVersion         	= 0x5006,
			PrintFlagsCrop            	= 0x5007,
			PrintFlagsBleedWidth      	= 0x5008,
			PrintFlagsBleedWidthScale 	= 0x5009,
			HalftoneLPI               	= 0x500A,
			HalftoneLPIUnit           	= 0x500B,
			HalftoneDegree            	= 0x500C,
			HalftoneShape             	= 0x500D,
			HalftoneMisc              	= 0x500E,
			HalftoneScreen            	= 0x500F,
			JPEGQuality               	= 0x5010,
			GridSize                  	= 0x5011,
			ThumbnailFormat          	= 0x5012,  // 0 = RAW RGB, 1 = JPEG
			ThumbnailWidth            	= 0x5013,
			ThumbnailHeight           	= 0x5014,
			ThumbnailColorDepth       	= 0x5015,
			ThumbnailPlanes           	= 0x5016,
			ThumbnailRawBytes         	= 0x5017,
			ThumbnailSize             	= 0x5018,
			ThumbnailCompressedSize   	= 0x5019,
			ColorTransferFunction     	= 0x501A,
			ThumbnailData             	= 0x501B, // embeded image, format depends on ThumbnailFormat
			ThumbnailImageWidth       	= 0x5020,
			ThumbnailImageHeight      	= 0x5021,
			ThumbnailBitsPerSample    	= 0x5022,
			ThumbnailCompression      	= 0x5023,
			ThumbnailPhotometricInterp 	= 0x5024,
			ThumbnailImageDescription 	= 0x5025,
			ThumbnailEquipMake        	= 0x5026,
			ThumbnailEquipModel       	= 0x5027,
			ThumbnailStripOffsets     	= 0x5028,
			ThumbnailOrientation      	= 0x5029,
			ThumbnailSamplesPerPixel  	= 0x502A,
			ThumbnailRowsPerStrip     	= 0x502B,
			ThumbnailStripBytesCount  	= 0x502C,
			ThumbnailResolutionX      	= 0x502D,
			ThumbnailResolutionY      	= 0x502E,
			ThumbnailPlanarConfig     	= 0x502F,
			ThumbnailResolutionUnit   	= 0x5030,
			ThumbnailTransferFunction 	= 0x5031,
			ThumbnailSoftwareUsed     	= 0x5032,
			ThumbnailDateTime         	= 0x5033,
			ThumbnailArtist           	= 0x5034,
			ThumbnailWhitePoint       	= 0x5035,
			ThumbnailPrimaryChromaticities	= 0x5036,
			ThumbnailYCbCrCoefficients 	= 0x5037,
			ThumbnailYCbCrSubsampling 	= 0x5038,
			ThumbnailYCbCrPositioning 	= 0x5039,
			ThumbnailRefBlackWhite    	= 0x503A,
			ThumbnailCopyRight        	= 0x503B,
			LuminanceTable            	= 0x5090,
			ChrominanceTable          	= 0x5091,

			FrameDelay                	= 0x5100,
			LoopCount                 	= 0x5101,

			PixelUnit         		= 0x5110,
			PixelPerUnitX     		= 0x5111,
			PixelPerUnitY     		= 0x5112,
			PaletteHistogram  		= 0x5113,

			// EXIF specific tag
			ExifExposureTime  		= 0x829A,
			ExifFNumber       		= 0x829D,

			ExifExposureProg  		= 0x8822,
			ExifSpectralSense 		= 0x8824,
			ExifISOSpeed      		= 0x8827,
			ExifOECF          		= 0x8828,

			ExifVer            		= 0x9000,
			ExifDTOrig         		= 0x9003,
			ExifDTDigitized    		= 0x9004,

			ExifCompConfig     		= 0x9101,
			ExifCompBPP        		= 0x9102,

			ExifShutterSpeed   		= 0x9201,
			ExifAperture       		= 0x9202,
			ExifBrightness     		= 0x9203,
			ExifExposureBias		= 0x9204,
			ExifMaxAperture			= 0x9205,
			ExifSubjectDist			= 0x9206,
			ExifMeteringMode	 	= 0x9207,
			ExifLightSource	 		= 0x9208,
			ExifFlash		 	= 0x9209,
			ExifFocalLength	 		= 0x920A,
			ExifMakerNote	 		= 0x927C,
			ExifUserComment			= 0x9286,
			ExifDTSubsec		 	= 0x9290,
			ExifDTOrigSS		 	= 0x9291,
			ExifDTDigSS		 	= 0x9292,

			ExifFPXVer		 	= 0xA000,
			ExifColorSpace	 		= 0xA001,
			ExifPixXDim		 	= 0xA002,
			ExifPixYDim		  	= 0xA003,
			ExifRelatedWav	  		= 0xA004,
			ExifInterop        		= 0xA005,
			ExifFlashEnergy    		= 0xA20B,
			ExifSpatialFR      		= 0xA20C,
			ExifFocalXRes      		= 0xA20E,
			ExifFocalYRes      		= 0xA20F,
			ExifFocalResUnit   		= 0xA210,
			ExifSubjectLoc     		= 0xA214,
			ExifExposureIndex  		= 0xA215,
			ExifSensingMethod  		= 0xA217,
			ExifFileSource     		= 0xA300,
			ExifSceneType      		= 0xA301,
			ExifCfaPattern     		= 0xA302,

			GpsVer             		= 0x0000,
			GpsLatitudeRef     		= 0x0001,
			GpsLatitude        		= 0x0002,
			GpsLongitudeRef    		= 0x0003,
			GpsLongitude       		= 0x0004,
			GpsAltitudeRef			= 0x0005,
			GpsAltitude			= 0x0006,
			GpsGpsTime			= 0x0007,
			GpsGpsSatellites		= 0x0008,
			GpsGpsStatus			= 0x0009,
			GpsGpsMeasureMode		= 0x000A,
			GpsGpsDop			= 0x000B,
			GpsSpeedRef			= 0x000C,
			GpsSpeed			= 0x000D,
			GpsTrackRef			= 0x000E,
			GpsTrack			= 0x000F,
			GpsImgDirRef			= 0x0010,
			GpsImgDir			= 0x0011,
			GpsMapDatum			= 0x0012,
			GpsDestLatRef			= 0x0013,
			GpsDestLat			= 0x0014,
			GpsDestLongRef			= 0x0015,
			GpsDestLong			= 0x0016,
			GpsDestBearRef			= 0x0017,
			GpsDestBear			= 0x0018,
			GpsDestDistRef			= 0x0019,
			GpsDestDist			= 0x001A
		}
		static string PropertyToString(PropertyTagType type, byte[] bytes) {

			switch(type) {
				case PropertyTagType.Byte: {
					return bytes[0].ToString();
				}

				case PropertyTagType.ASCII: {
					StringBuilder sb;

					sb = new StringBuilder();
					for (int i = 0; i < bytes.Length; i++) {
						if (!Char.IsControl((char)bytes[i])) {
							sb.Append((char)bytes[i]);
						}
					}
					return sb.ToString();
				}

				case PropertyTagType.Short: {
					ushort s;

					s = (ushort)(bytes[0] * 256 + bytes[1]);
					return s.ToString();
				}

				case PropertyTagType.Long: {
					uint l;

					l = (uint)(bytes[3] * 16777216 + bytes[2] * 65536 + bytes[1] * 256 + bytes[0]);
					return l.ToString();
				}

				case PropertyTagType.SRational: {
					ushort numerator;
					ushort denominator;

					numerator = (ushort)(bytes[1] * 256 + bytes[0]);
					denominator = (ushort)(bytes[3] * 256 + bytes[2]);
					return String.Format("{0} / {1})", numerator, denominator);
				}


				case PropertyTagType.Rational: {
					uint numerator;
					uint denominator;

					numerator = (uint)(bytes[3] * 16777216 + bytes[2] * 65536 + bytes[1] * 256  + bytes[0]);
					denominator = (uint)(bytes[7] * 16777216 + bytes[6] * 65536 + bytes[5] * 256 + bytes[4]);
					return String.Format("{0} / {1}", numerator, denominator);
				}

				default: {
					return "<"+type.ToString()+">";
				}
			}
		}

		static void AnalyzeImage(string filename) {
			Bitmap		bmp;
			bool		page;
			bool		time;
			bool		resolution;
			int		current_frame;
			int		frame_count;
			BitmapData	bitmap_data;

			page = false;
			time = false;
			resolution = false;
			current_frame = 0;
			frame_count = 0;

			bmp = new Bitmap(filename);
			if (bmp != null) {
				Guid[]		list;
				PropertyItem[]	items;

				Console.WriteLine("Loaded image '{0}'", filename);

				list = bmp.FrameDimensionsList;

				Console.Write("Supported dimensions:");
				for (int i = 0; i < list.Length; i++) {
					if (FrameDimension.Page.Guid == list[i]) {
						Console.Write("  Page");
						page = true;
					} else if (FrameDimension.Time.Guid == list[i]) {
						Console.Write("  Time");
						time = true;
					} else if (FrameDimension.Resolution.Guid == list[i]) {
						Console.Write("  Resolution");
						resolution = true;
					}
				}
				Console.WriteLine("");

				if (resolution) {
					frame_count = bmp.GetFrameCount(FrameDimension.Resolution);
					Console.WriteLine("FrameCount(Resolution):{0}", frame_count);
				}
				if (time) {
					frame_count = bmp.GetFrameCount(FrameDimension.Time);
					Console.WriteLine("FrameCount(Time):{0}", frame_count);
				}
				if (page) {
					frame_count = bmp.GetFrameCount(FrameDimension.Page);
					Console.WriteLine("FrameCount(Page):{0}", frame_count);
				}

				do {
					if (page) {
						bmp.SelectActiveFrame(FrameDimension.Page, current_frame);
					} else if (time) {
						bmp.SelectActiveFrame(FrameDimension.Time, current_frame);
					} else if (resolution) {
						bmp.SelectActiveFrame(FrameDimension.Resolution, current_frame);
					}
					Console.WriteLine("Active Frame: {0}", current_frame);
					Console.WriteLine(" {0}x{1} pixels", bmp.Width, bmp.Height);
					Console.WriteLine(" {0}x{1} physical dimensions", bmp.PhysicalDimension.Width, bmp.PhysicalDimension.Height);
					Console.WriteLine(" {0}x{1} dpi", bmp.HorizontalResolution, bmp.VerticalResolution);
					Console.WriteLine(" Flags: {0}", (ImageFlags)bmp.Flags);

					bitmap_data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
					if (bitmap_data != null) {
						Console.WriteLine(" BitmapData: {0}x{1} pixels, Stride:{2}, PixelFormat:{3}", bitmap_data.Width, bitmap_data.Height, bitmap_data.Stride, bitmap_data.PixelFormat);
						bmp.UnlockBits(bitmap_data);
					} else {
						Console.WriteLine("Error: Could not get BitmapData");
					}
					
					items = bmp.PropertyItems;
					Console.WriteLine("\n Frame {0}, Property count: {1}", current_frame, items.Length);
					for (int i = 0; i < items.Length; i++) {
						Console.WriteLine("   [{0,2}]: {1,-10} {2,23} = {3}", i, (PropertyTagType)items[i].Type, (PropertyTag)items[i].Id, PropertyToString((PropertyTagType)items[i].Type, items[i].Value));
					}
					Console.WriteLine("");

					current_frame++;
					if (current_frame >= frame_count) {
						if (page) {
							page = false;
							if (time || resolution) {
								frame_count = 0;
							}
						}
						if (time) {
							time = false;
							if (resolution) {
								frame_count = 0;
							}
						}
					}
				} while (current_frame < frame_count);

				bmp.Dispose();
			}

		}

		// FIXME - make me into a real winforms app, using propertygrid to display 
		// the properties and info and a picturebox for a preview
		// For the libgdiplus image refactor this will do as is
		static void Main(string[] arg) {
			if (arg.Length > 0) {
				for (int i = 0; i < arg.Length; i++) {
					try {
						AnalyzeImage(arg[i]);
					}
					catch (Exception e) {
						Console.WriteLine("Failed processing image {0}, Exception:{1}", arg[i], e.Message);
					}
				}
				return;
			}

			//AnalyzeImage("ani.gif");
			//AnalyzeImage("photo.jpg");
			AnalyzeImage("multipage.tif");
		}
	}
}

