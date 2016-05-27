/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Mon Sep 27 14:30:30 2010
* Arguments: "-B" "macro_default" "-W" "dotnet:DIFFWIZ,Diffraction,0.0,private" "-d"
* "C:\Users\maher\My Dropbox\Lund\DIFFWIZ\DIFFWIZ\src" "-T" "link:lib" "-v"
* "class{Diffraction:C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\arrow3D.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Structure\CartesianSystem.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\column3D.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\AtomicProperties\Density.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Electrons\ElectronRealScatteringFactor.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\GeometricalSimulation1.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\MultipeakIntensities.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\normalize.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\PlotCoplanarGeom.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\PlotNonCoplanarGeom.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\plotp.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\rotatePoints.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\3DVectorPlotting\scatter3_2.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\AtomicProperties\ScatteringFactor.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\StructureFactor.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Structure\VisualizeCrystal.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayAttenuationLength.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayComplexScatteringFactor.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayIndexOfRefraction.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayRealScatteringFactor.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayReflectivity.m,C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayTransmission.m}" "-a" "C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\AtomicProperties\AtomicWeights.mat" "-a" "C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Electrons\ElectronRealSF.mat" "-a" "C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayMassAttenuation" "-a" "C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayRealSF.mat" "-a" "C:\Users\maher\My
* Dropbox\Lund\DIFFWIZ\Xrays\XrayScatteringData" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace DIFFWIZ
{
  /// <summary>
  /// The Diffraction class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\arrow3D.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Structure\CartesianSystem.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\column3D.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\AtomicProperties\Density.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Electrons\ElectronRealScatteringFactor.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\GeometricalSimulation1.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\MultipeakIntensities.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\normalize.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\PlotCoplanarGeom.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\PlotNonCoplanarGeom.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\plotp.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\rotatePoints.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\3DVectorPlotting\scatter3_2.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\AtomicProperties\ScatteringFactor.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\StructureFactor.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Structure\VisualizeCrystal.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\XrayAttenuationLength.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\XrayComplexScatteringFactor.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\XrayIndexOfRefraction.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\XrayRealScatteringFactor.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\XrayReflectivity.m
  /// <newpara></newpara>
  /// C:\Users\maher\My Dropbox\Lund\DIFFWIZ\Xrays\XrayTransmission.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Diffraction : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static Diffraction()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_DIFFWIZ_name_data + ".ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR(MCRComponentState.MCC_DIFFWIZ_name_data,
                       MCRComponentState.MCC_DIFFWIZ_root_data,
                       MCRComponentState.MCC_DIFFWIZ_public_data,
                       MCRComponentState.MCC_DIFFWIZ_session_data,
                       MCRComponentState.MCC_DIFFWIZ_matlabpath_data,
                       MCRComponentState.MCC_DIFFWIZ_classpath_data,
                       MCRComponentState.MCC_DIFFWIZ_libpath_data,
                       MCRComponentState.MCC_DIFFWIZ_mcr_application_options,
                       MCRComponentState.MCC_DIFFWIZ_mcr_runtime_options,
                       MCRComponentState.MCC_DIFFWIZ_mcr_pref_dir,
                       MCRComponentState.MCC_DIFFWIZ_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Diffraction class.
    /// </summary>
    public Diffraction()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Diffraction()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray arrow3D()
    {
      return mcr.EvaluateFunction("arrow3D", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray arrow3D(MWArray pos)
    {
      return mcr.EvaluateFunction("arrow3D", pos);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray arrow3D(MWArray pos, MWArray deltaValues)
    {
      return mcr.EvaluateFunction("arrow3D", pos, deltaValues);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray arrow3D(MWArray pos, MWArray deltaValues, MWArray colorCode)
    {
      return mcr.EvaluateFunction("arrow3D", pos, deltaValues, colorCode);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <param name="stemRatio">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray arrow3D(MWArray pos, MWArray deltaValues, MWArray colorCode, MWArray 
                     stemRatio)
    {
      return mcr.EvaluateFunction("arrow3D", pos, deltaValues, colorCode, stemRatio);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] arrow3D(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "arrow3D", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] arrow3D(int numArgsOut, MWArray pos)
    {
      return mcr.EvaluateFunction(numArgsOut, "arrow3D", pos);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] arrow3D(int numArgsOut, MWArray pos, MWArray deltaValues)
    {
      return mcr.EvaluateFunction(numArgsOut, "arrow3D", pos, deltaValues);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] arrow3D(int numArgsOut, MWArray pos, MWArray deltaValues, MWArray 
                       colorCode)
    {
      return mcr.EvaluateFunction(numArgsOut, "arrow3D", pos, deltaValues, colorCode);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the arrow3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <param name="stemRatio">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] arrow3D(int numArgsOut, MWArray pos, MWArray deltaValues, MWArray 
                       colorCode, MWArray stemRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "arrow3D", pos, deltaValues, colorCode, stemRatio);
    }


    /// <summary>
    /// Provides an interface for the arrow3D function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// arrowHandle = arrow3D(pos, deltaValues, colorCode, stemRatio)                    
    /// Used to plot a single 3D arrow with a cylindrical stem and cone arrowhead
    /// pos = [X,Y,Z] - spatial location of the starting point of the arrow (end of stem)
    /// deltaValues = [QX,QY,QZ] - delta parameters denoting the magnitude of the arrow
    /// along the x,y,z-axes (relative to 'pos')
    /// colorCode - Color parameters as per the 'surf' command.  For example, 'r', 'red',
    /// [1 0 0] are all examples of a red-colored arrow
    /// stemRatio - The ratio of the length of the stem in proportion to the arrowhead. 
    /// For example, a call of:
    /// arrow3D([0,0,0], [100,0,0] , 'r', 0.82) will produce a red arrow of magnitude
    /// 100, with the arrowstem spanning a distance
    /// of 82 (note 0.82 ratio of length 100) while the arrowhead (cone) spans 18.  
    /// Example:
    /// arrow3D([0,0,0], [4,3,7]);    ---- arrow with default parameters
    /// axis equal;
    /// Author: Shawn Arseneau
    /// Created: September 14, 2006
    /// Updated: September 18, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void arrow3D(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("arrow3D", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the CartesianSystem
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice.LatticeVectors = [Lattice.a 0 0; -sin(pi/6)*Lattice.a cos(pi/6)*Lattice.a
    /// 0; 0 0 Lattice.c];
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray CartesianSystem()
    {
      return mcr.EvaluateFunction("CartesianSystem", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the CartesianSystem
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice.LatticeVectors = [Lattice.a 0 0; -sin(pi/6)*Lattice.a cos(pi/6)*Lattice.a
    /// 0; 0 0 Lattice.c];
    /// </remarks>
    /// <param name="Lattice_in1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray CartesianSystem(MWArray Lattice_in1)
    {
      return mcr.EvaluateFunction("CartesianSystem", Lattice_in1);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the CartesianSystem
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice.LatticeVectors = [Lattice.a 0 0; -sin(pi/6)*Lattice.a cos(pi/6)*Lattice.a
    /// 0; 0 0 Lattice.c];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CartesianSystem(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CartesianSystem", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the CartesianSystem
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice.LatticeVectors = [Lattice.a 0 0; -sin(pi/6)*Lattice.a cos(pi/6)*Lattice.a
    /// 0; 0 0 Lattice.c];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice_in1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CartesianSystem(int numArgsOut, MWArray Lattice_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "CartesianSystem", Lattice_in1);
    }


    /// <summary>
    /// Provides an interface for the CartesianSystem function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Lattice.LatticeVectors = [Lattice.a 0 0; -sin(pi/6)*Lattice.a cos(pi/6)*Lattice.a
    /// 0; 0 0 Lattice.c];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void CartesianSystem(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("CartesianSystem", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray column3D()
    {
      return mcr.EvaluateFunction("column3D", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray column3D(MWArray pos)
    {
      return mcr.EvaluateFunction("column3D", pos);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray column3D(MWArray pos, MWArray deltaValues)
    {
      return mcr.EvaluateFunction("column3D", pos, deltaValues);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray column3D(MWArray pos, MWArray deltaValues, MWArray colorCode)
    {
      return mcr.EvaluateFunction("column3D", pos, deltaValues, colorCode);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <param name="stemRatio">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray column3D(MWArray pos, MWArray deltaValues, MWArray colorCode, MWArray 
                      stemRatio)
    {
      return mcr.EvaluateFunction("column3D", pos, deltaValues, colorCode, stemRatio);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] column3D(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "column3D", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] column3D(int numArgsOut, MWArray pos)
    {
      return mcr.EvaluateFunction(numArgsOut, "column3D", pos);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] column3D(int numArgsOut, MWArray pos, MWArray deltaValues)
    {
      return mcr.EvaluateFunction(numArgsOut, "column3D", pos, deltaValues);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] column3D(int numArgsOut, MWArray pos, MWArray deltaValues, MWArray 
                        colorCode)
    {
      return mcr.EvaluateFunction(numArgsOut, "column3D", pos, deltaValues, colorCode);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the column3D M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pos">Input argument #1</param>
    /// <param name="deltaValues">Input argument #2</param>
    /// <param name="colorCode">Input argument #3</param>
    /// <param name="stemRatio">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] column3D(int numArgsOut, MWArray pos, MWArray deltaValues, MWArray 
                        colorCode, MWArray stemRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "column3D", pos, deltaValues, colorCode, stemRatio);
    }


    /// <summary>
    /// Provides an interface for the column3D function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// COLUMN3D - plot column in three dimensions
    /// ( very slight modification of ARROW3D.m written by Shawn Arseneau)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void column3D(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("column3D", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the Density M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Density()
    {
      return mcr.EvaluateFunction("Density", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the Density M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Density(MWArray Lattice)
    {
      return mcr.EvaluateFunction("Density", Lattice);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the Density M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Density(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Density", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the Density M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Density(int numArgsOut, MWArray Lattice)
    {
      return mcr.EvaluateFunction(numArgsOut, "Density", Lattice);
    }


    /// <summary>
    /// Provides an interface for the Density function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void Density(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("Density", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElectronRealScatteringFactor()
    {
      return mcr.EvaluateFunction("ElectronRealScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElectronRealScatteringFactor(MWArray Z)
    {
      return mcr.EvaluateFunction("ElectronRealScatteringFactor", Z);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElectronRealScatteringFactor(MWArray Z, MWArray s)
    {
      return mcr.EvaluateFunction("ElectronRealScatteringFactor", Z, s);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElectronRealScatteringFactor(MWArray Z, MWArray s, MWArray FigNum)
    {
      return mcr.EvaluateFunction("ElectronRealScatteringFactor", Z, s, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElectronRealScatteringFactor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElectronRealScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElectronRealScatteringFactor(int numArgsOut, MWArray Z)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElectronRealScatteringFactor", Z);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElectronRealScatteringFactor(int numArgsOut, MWArray Z, MWArray s)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElectronRealScatteringFactor", Z, s);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the
    /// ElectronRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElectronRealScatteringFactor(int numArgsOut, MWArray Z, MWArray s, 
                                            MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElectronRealScatteringFactor", Z, s, FigNum);
    }


    /// <summary>
    /// Provides an interface for the ElectronRealScatteringFactor function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void ElectronRealScatteringFactor(int numArgsOut, ref MWArray[] argsOut, 
                                   MWArray[] argsIn)
    {
      mcr.EvaluateFunction("ElectronRealScatteringFactor", numArgsOut, ref argsOut, 
                                   argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray GeometricalSimulation1()
    {
      return mcr.EvaluateFunction("GeometricalSimulation1", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray GeometricalSimulation1(MWArray Lattice)
    {
      return mcr.EvaluateFunction("GeometricalSimulation1", Lattice);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray GeometricalSimulation1(MWArray Lattice, MWArray Probe)
    {
      return mcr.EvaluateFunction("GeometricalSimulation1", Lattice, Probe);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="Detector">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray GeometricalSimulation1(MWArray Lattice, MWArray Probe, MWArray 
                                    Detector)
    {
      return mcr.EvaluateFunction("GeometricalSimulation1", Lattice, Probe, Detector);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="Detector">Input argument #3</param>
    /// <param name="hkl_space">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray GeometricalSimulation1(MWArray Lattice, MWArray Probe, MWArray 
                                    Detector, MWArray hkl_space)
    {
      return mcr.EvaluateFunction("GeometricalSimulation1", Lattice, Probe, Detector, hkl_space);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="Detector">Input argument #3</param>
    /// <param name="hkl_space">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray GeometricalSimulation1(MWArray Lattice, MWArray Probe, MWArray 
                                    Detector, MWArray hkl_space, MWArray FigNum)
    {
      return mcr.EvaluateFunction("GeometricalSimulation1", Lattice, Probe, Detector, hkl_space, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] GeometricalSimulation1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "GeometricalSimulation1", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] GeometricalSimulation1(int numArgsOut, MWArray Lattice)
    {
      return mcr.EvaluateFunction(numArgsOut, "GeometricalSimulation1", Lattice);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] GeometricalSimulation1(int numArgsOut, MWArray Lattice, MWArray 
                                      Probe)
    {
      return mcr.EvaluateFunction(numArgsOut, "GeometricalSimulation1", Lattice, Probe);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="Detector">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] GeometricalSimulation1(int numArgsOut, MWArray Lattice, MWArray 
                                      Probe, MWArray Detector)
    {
      return mcr.EvaluateFunction(numArgsOut, "GeometricalSimulation1", Lattice, Probe, Detector);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="Detector">Input argument #3</param>
    /// <param name="hkl_space">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] GeometricalSimulation1(int numArgsOut, MWArray Lattice, MWArray 
                                      Probe, MWArray Detector, MWArray hkl_space)
    {
      return mcr.EvaluateFunction(numArgsOut, "GeometricalSimulation1", Lattice, Probe, Detector, hkl_space);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the GeometricalSimulation1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="Detector">Input argument #3</param>
    /// <param name="hkl_space">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] GeometricalSimulation1(int numArgsOut, MWArray Lattice, MWArray 
                                      Probe, MWArray Detector, MWArray hkl_space, MWArray 
                                      FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "GeometricalSimulation1", Lattice, Probe, Detector, hkl_space, FigNum);
    }


    /// <summary>
    /// Provides an interface for the GeometricalSimulation1 function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void GeometricalSimulation1(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                             argsIn)
    {
      mcr.EvaluateFunction("GeometricalSimulation1", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities()
    {
      return mcr.EvaluateFunction("MultipeakIntensities", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe, MWArray hkl_space)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe, hkl_space);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe, MWArray 
                                  hkl_space, MWArray Q_Range)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe, MWArray 
                                  hkl_space, MWArray Q_Range, MWArray s_scale)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe, MWArray 
                                  hkl_space, MWArray Q_Range, MWArray s_scale, MWArray 
                                  FigNum)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <param name="pltColors">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe, MWArray 
                                  hkl_space, MWArray Q_Range, MWArray s_scale, MWArray 
                                  FigNum, MWArray pltColors)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum, pltColors);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <param name="pltColors">Input argument #7</param>
    /// <param name="KeepFigOpen">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MultipeakIntensities(MWArray Lattice, MWArray Probe, MWArray 
                                  hkl_space, MWArray Q_Range, MWArray s_scale, MWArray 
                                  FigNum, MWArray pltColors, MWArray KeepFigOpen)
    {
      return mcr.EvaluateFunction("MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum, pltColors, KeepFigOpen);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe, 
                                    MWArray hkl_space)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe, hkl_space);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe, 
                                    MWArray hkl_space, MWArray Q_Range)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe, 
                                    MWArray hkl_space, MWArray Q_Range, MWArray s_scale)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe, 
                                    MWArray hkl_space, MWArray Q_Range, MWArray s_scale, 
                                    MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <param name="pltColors">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe, 
                                    MWArray hkl_space, MWArray Q_Range, MWArray s_scale, 
                                    MWArray FigNum, MWArray pltColors)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum, pltColors);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the MultipeakIntensities
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Probe">Input argument #2</param>
    /// <param name="hkl_space">Input argument #3</param>
    /// <param name="Q_Range">Input argument #4</param>
    /// <param name="s_scale">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <param name="pltColors">Input argument #7</param>
    /// <param name="KeepFigOpen">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MultipeakIntensities(int numArgsOut, MWArray Lattice, MWArray Probe, 
                                    MWArray hkl_space, MWArray Q_Range, MWArray s_scale, 
                                    MWArray FigNum, MWArray pltColors, MWArray 
                                    KeepFigOpen)
    {
      return mcr.EvaluateFunction(numArgsOut, "MultipeakIntensities", Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum, pltColors, KeepFigOpen);
    }


    /// <summary>
    /// Provides an interface for the MultipeakIntensities function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale
    /// FigNum
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void MultipeakIntensities(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                           argsIn)
    {
      mcr.EvaluateFunction("MultipeakIntensities", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the normalize M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// NORMALIZE - return vector with unit length
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray normalize()
    {
      return mcr.EvaluateFunction("normalize", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the normalize M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// NORMALIZE - return vector with unit length
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray normalize(MWArray x)
    {
      return mcr.EvaluateFunction("normalize", x);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the normalize M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// NORMALIZE - return vector with unit length
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] normalize(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "normalize", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the normalize M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// NORMALIZE - return vector with unit length
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] normalize(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "normalize", x);
    }


    /// <summary>
    /// Provides an interface for the normalize function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// NORMALIZE - return vector with unit length
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void normalize(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("normalize", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the PlotCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// reference point
    /// </remarks>
    ///
    public void PlotCoplanarGeom()
    {
      mcr.EvaluateFunction(0, "PlotCoplanarGeom", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the PlotCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// reference point
    /// </remarks>
    /// <param name="StructureFactor">Input argument #1</param>
    ///
    public void PlotCoplanarGeom(MWArray StructureFactor)
    {
      mcr.EvaluateFunction(0, "PlotCoplanarGeom", StructureFactor);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the PlotCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// reference point
    /// </remarks>
    /// <param name="StructureFactor">Input argument #1</param>
    /// <param name="FigNum">Input argument #2</param>
    ///
    public void PlotCoplanarGeom(MWArray StructureFactor, MWArray FigNum)
    {
      mcr.EvaluateFunction(0, "PlotCoplanarGeom", StructureFactor, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PlotCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// reference point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotCoplanarGeom(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotCoplanarGeom", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PlotCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// reference point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="StructureFactor">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotCoplanarGeom(int numArgsOut, MWArray StructureFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotCoplanarGeom", StructureFactor);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PlotCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// reference point
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="StructureFactor">Input argument #1</param>
    /// <param name="FigNum">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotCoplanarGeom(int numArgsOut, MWArray StructureFactor, MWArray 
                                FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotCoplanarGeom", StructureFactor, FigNum);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PlotNonCoplanarGeom()
    {
      return mcr.EvaluateFunction("PlotNonCoplanarGeom", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PlotNonCoplanarGeom(MWArray BraggAngle)
    {
      return mcr.EvaluateFunction("PlotNonCoplanarGeom", BraggAngle);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PlotNonCoplanarGeom(MWArray BraggAngle, MWArray IncidentPsi)
    {
      return mcr.EvaluateFunction("PlotNonCoplanarGeom", BraggAngle, IncidentPsi);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <param name="SurfaceNormal">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PlotNonCoplanarGeom(MWArray BraggAngle, MWArray IncidentPsi, MWArray 
                                 SurfaceNormal)
    {
      return mcr.EvaluateFunction("PlotNonCoplanarGeom", BraggAngle, IncidentPsi, SurfaceNormal);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <param name="SurfaceNormal">Input argument #3</param>
    /// <param name="ReflectionNormal">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PlotNonCoplanarGeom(MWArray BraggAngle, MWArray IncidentPsi, MWArray 
                                 SurfaceNormal, MWArray ReflectionNormal)
    {
      return mcr.EvaluateFunction("PlotNonCoplanarGeom", BraggAngle, IncidentPsi, SurfaceNormal, ReflectionNormal);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <param name="SurfaceNormal">Input argument #3</param>
    /// <param name="ReflectionNormal">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PlotNonCoplanarGeom(MWArray BraggAngle, MWArray IncidentPsi, MWArray 
                                 SurfaceNormal, MWArray ReflectionNormal, MWArray FigNum)
    {
      return mcr.EvaluateFunction("PlotNonCoplanarGeom", BraggAngle, IncidentPsi, SurfaceNormal, ReflectionNormal, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotNonCoplanarGeom(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotNonCoplanarGeom", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotNonCoplanarGeom(int numArgsOut, MWArray BraggAngle)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotNonCoplanarGeom", BraggAngle);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotNonCoplanarGeom(int numArgsOut, MWArray BraggAngle, MWArray 
                                   IncidentPsi)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotNonCoplanarGeom", BraggAngle, IncidentPsi);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <param name="SurfaceNormal">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotNonCoplanarGeom(int numArgsOut, MWArray BraggAngle, MWArray 
                                   IncidentPsi, MWArray SurfaceNormal)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotNonCoplanarGeom", BraggAngle, IncidentPsi, SurfaceNormal);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <param name="SurfaceNormal">Input argument #3</param>
    /// <param name="ReflectionNormal">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotNonCoplanarGeom(int numArgsOut, MWArray BraggAngle, MWArray 
                                   IncidentPsi, MWArray SurfaceNormal, MWArray 
                                   ReflectionNormal)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotNonCoplanarGeom", BraggAngle, IncidentPsi, SurfaceNormal, ReflectionNormal);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the PlotNonCoplanarGeom
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BraggAngle">Input argument #1</param>
    /// <param name="IncidentPsi">Input argument #2</param>
    /// <param name="SurfaceNormal">Input argument #3</param>
    /// <param name="ReflectionNormal">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotNonCoplanarGeom(int numArgsOut, MWArray BraggAngle, MWArray 
                                   IncidentPsi, MWArray SurfaceNormal, MWArray 
                                   ReflectionNormal, MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotNonCoplanarGeom", BraggAngle, IncidentPsi, SurfaceNormal, ReflectionNormal, FigNum);
    }


    /// <summary>
    /// Provides an interface for the PlotNonCoplanarGeom function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// save test2.mat BraggAngle IncidentPsi SurfaceNormal ReflectionNormal
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PlotNonCoplanarGeom(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                          argsIn)
    {
      mcr.EvaluateFunction("PlotNonCoplanarGeom", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray plotp()
    {
      return mcr.EvaluateFunction("plotp", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="v1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray plotp(MWArray v1)
    {
      return mcr.EvaluateFunction("plotp", v1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="v1">Input argument #1</param>
    /// <param name="v2">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray plotp(MWArray v1, MWArray v2)
    {
      return mcr.EvaluateFunction("plotp", v1, v2);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="v1">Input argument #1</param>
    /// <param name="v2">Input argument #2</param>
    /// <param name="str">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray plotp(MWArray v1, MWArray v2, MWArray str)
    {
      return mcr.EvaluateFunction("plotp", v1, v2, str);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotp(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotp", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="v1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotp(int numArgsOut, MWArray v1)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotp", v1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="v1">Input argument #1</param>
    /// <param name="v2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotp(int numArgsOut, MWArray v1, MWArray v2)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotp", v1, v2);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the plotp M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="v1">Input argument #1</param>
    /// <param name="v2">Input argument #2</param>
    /// <param name="str">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotp(int numArgsOut, MWArray v1, MWArray v2, MWArray str)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotp", v1, v2, str);
    }


    /// <summary>
    /// Provides an interface for the plotp function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// PLOTP - plot a plane or line in 3 dimensions.
    /// For the first two arguments, user supplies two linearly independent 3x1 vectors,
    /// and output 
    /// is a graph of the plane generated by these two vectors. A single input of
    /// one 3x2 matrix is also ok.
    /// The user may specify just one vector. The plot will 
    /// then be just the line generated by that vector.  
    /// The plot will also be a line if the two input vectors are linearly
    /// dependent. 
    /// Optional 3rd argument: User may also specify a string that determines the plot
    /// style of the
    /// plane, using the same string options as for MATLAB's plot function.
    /// OTHER FUNCTIONS REQUIRED: arrow3D.m (by Shawn Arseneau), column3D.m,
    /// scatter3_2.m, normalize.m
    /// EXAMPLE:  >> plotp([1;1;1],[2;2;-4])
    /// >> plotp([1;1;1],[3;-3;0],'m')
    /// EXAMPLE: for matrix of rank 1, plot the 2 dimensional nullspace (a plane), and 1
    /// dimensional row space (a line), the two should be visibly orthogonal subspaces
    /// >> A=[1 0 0; 2 0 0; 3 0 0]
    /// A =
    /// 1     0     0
    /// 2     0     0
    /// 3     0     0
    /// >> hold on
    /// >> plotp(null(A))
    /// >> plotp(orth(A'),'m')
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void plotp(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("plotp", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the rotatePoints
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray rotatePoints()
    {
      return mcr.EvaluateFunction("rotatePoints", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the rotatePoints
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <param name="alignmentVector">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray rotatePoints(MWArray alignmentVector)
    {
      return mcr.EvaluateFunction("rotatePoints", alignmentVector);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the rotatePoints
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <param name="alignmentVector">Input argument #1</param>
    /// <param name="originalData">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray rotatePoints(MWArray alignmentVector, MWArray originalData)
    {
      return mcr.EvaluateFunction("rotatePoints", alignmentVector, originalData);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the rotatePoints M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] rotatePoints(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "rotatePoints", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the rotatePoints M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="alignmentVector">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] rotatePoints(int numArgsOut, MWArray alignmentVector)
    {
      return mcr.EvaluateFunction(numArgsOut, "rotatePoints", alignmentVector);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the rotatePoints M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="alignmentVector">Input argument #1</param>
    /// <param name="originalData">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] rotatePoints(int numArgsOut, MWArray alignmentVector, MWArray 
                            originalData)
    {
      return mcr.EvaluateFunction(numArgsOut, "rotatePoints", alignmentVector, originalData);
    }


    /// <summary>
    /// Provides an interface for the rotatePoints function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// rotatedData = rotatePoints(alignmentVector, originalData)                        
    /// Rotate the 'originalData' in the form of Nx2 or Nx3 about the origin by aligning
    /// the x-axis with the alignment vector
    /// Rdata = rotatePoints([1,2,-1], [Xpts(:), Ypts(:), Zpts(:)]) - rotate the
    /// (X,Y,Z)pts in 3D with respect to the vector [1,2,-1]
    /// Rotating using spherical components can be done by first converting using
    /// [dX,dY,dZ] = cart2sph(theta, phi, rho);  alignmentVector = [dX,dY,dZ];
    /// Example:
    /// Rotate the point [3,4,-7] with respect to the following:
    /// Original associated vector is always [1,0,0]
    /// Calculate the appropriate rotation requested with respect to the x-axis.  For
    /// example, if only a rotation about the z-axis is
    /// sought, alignmentVector = [2,1,0]      Note that the z-component is zero
    /// rotData = rotatePoints(alignmentVector, [3,4,-7]);
    /// Author: Shawn Arseneau
    /// Created: Feb.2, 2006
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void rotatePoints(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("rotatePoints", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the scatter3_2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray scatter3_2()
    {
      return mcr.EvaluateFunction("scatter3_2", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the scatter3_2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray scatter3_2(MWArray X)
    {
      return mcr.EvaluateFunction("scatter3_2", X);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the scatter3_2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="str">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray scatter3_2(MWArray X, MWArray str)
    {
      return mcr.EvaluateFunction("scatter3_2", X, str);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the scatter3_2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] scatter3_2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "scatter3_2", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the scatter3_2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] scatter3_2(int numArgsOut, MWArray X)
    {
      return mcr.EvaluateFunction(numArgsOut, "scatter3_2", X);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the scatter3_2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="str">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] scatter3_2(int numArgsOut, MWArray X, MWArray str)
    {
      return mcr.EvaluateFunction(numArgsOut, "scatter3_2", X, str);
    }


    /// <summary>
    /// Provides an interface for the scatter3_2 function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// SCATTER3_2 - scatter plot 3 dimensional data 
    /// (slight modification of MATLAB's scatter3.m)
    /// First argument - input is an nx3 matrix. output is a scatter plot graph, where
    /// each point
    /// comes from one of the rows of the input matrix. The matrix must have 3
    /// columns.
    /// Optional second argument - string to determine plotting style, using same
    /// options as in MATLAB's plot function
    /// EXAMPLE:  >> A = rand(20,3);
    /// >> scatter3_2(A);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void scatter3_2(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("scatter3_2", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ScatteringFactor()
    {
      return mcr.EvaluateFunction("ScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ScatteringFactor(MWArray s)
    {
      return mcr.EvaluateFunction("ScatteringFactor", s);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="Z">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ScatteringFactor(MWArray s, MWArray Z)
    {
      return mcr.EvaluateFunction("ScatteringFactor", s, Z);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="Z">Input argument #2</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 3
    /// through varargin.length+2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ScatteringFactor(MWArray s, MWArray Z, params MWArray[] varargin)
    {
      MWArray[] args = {s, Z};
      int nonVarargInputNum = args.Length;
      int varargInputNum = varargin.Length;
      int totalNumArgs = varargInputNum > 0 ? (nonVarargInputNum + varargInputNum) : nonVarargInputNum;
      Array newArr = Array.CreateInstance(typeof(MWArray), totalNumArgs);

      int idx = 0;

      for (idx = 0; idx < nonVarargInputNum; idx++)
        newArr.SetValue(args[idx],idx);

      if (varargInputNum > 0)
      {
        for (int i = 0; i < varargInputNum; i++)
        {
          newArr.SetValue(varargin[i], idx);
          idx++;
        }
      }

      return mcr.EvaluateFunction("ScatteringFactor", (MWArray[])newArr );
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ScatteringFactor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ScatteringFactor(int numArgsOut, MWArray s)
    {
      return mcr.EvaluateFunction(numArgsOut, "ScatteringFactor", s);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <param name="Z">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ScatteringFactor(int numArgsOut, MWArray s, MWArray Z)
    {
      return mcr.EvaluateFunction(numArgsOut, "ScatteringFactor", s, Z);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the ScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <param name="Z">Input argument #2</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 3
    /// through varargin.length+2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ScatteringFactor(int numArgsOut, MWArray s, MWArray Z, params 
                                MWArray[] varargin)
    {
      MWArray[] args = {s, Z};
      int nonVarargInputNum = args.Length;
      int varargInputNum = varargin.Length;
      int totalNumArgs = varargInputNum > 0 ? (nonVarargInputNum + varargInputNum) : nonVarargInputNum;
      Array newArr = Array.CreateInstance(typeof(MWArray), totalNumArgs);

      int idx = 0;

      for (idx = 0; idx < nonVarargInputNum; idx++)
        newArr.SetValue(args[idx],idx);

      if (varargInputNum > 0)
      {
        for (int i = 0; i < varargInputNum; i++)
        {
          newArr.SetValue(varargin[i], idx);
          idx++;
        }
      }

      return mcr.EvaluateFunction(numArgsOut, "ScatteringFactor", (MWArray[])newArr );
    }


    /// <summary>
    /// Provides an interface for the ScatteringFactor function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// a1 b1 a2 b2 a3 b3 a4 b4 c
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void ScatteringFactor(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("ScatteringFactor", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the StructureFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray StructureFactor()
    {
      return mcr.EvaluateFunction("StructureFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the StructureFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <param name="Lattice_in1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray StructureFactor(MWArray Lattice_in1)
    {
      return mcr.EvaluateFunction("StructureFactor", Lattice_in1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the StructureFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <param name="Lattice_in1">Input argument #1</param>
    /// <param name="Probe_in1">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray StructureFactor(MWArray Lattice_in1, MWArray Probe_in1)
    {
      return mcr.EvaluateFunction("StructureFactor", Lattice_in1, Probe_in1);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the StructureFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] StructureFactor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "StructureFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the StructureFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice_in1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] StructureFactor(int numArgsOut, MWArray Lattice_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "StructureFactor", Lattice_in1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the StructureFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice_in1">Input argument #1</param>
    /// <param name="Probe_in1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] StructureFactor(int numArgsOut, MWArray Lattice_in1, MWArray 
                               Probe_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "StructureFactor", Lattice_in1, Probe_in1);
    }


    /// <summary>
    /// Provides an interface for the StructureFactor function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Lattice: a structure data-type containing:
    /// .Type: 'cubic', 'hexagonal', etc
    /// .a .b .c: lattice constants (depending on lattice type some of these are
    /// optional)
    /// .alpha .beta .gamma: lattice constants (depending on lattice type some of these
    /// are optional)
    /// .AtomicPositions: n by 3  matrix, each row represents atomic coordinates in space
    /// of the lattice (i.e. non cartesian) 
    /// .Reflection: a 1x3 vector containing the Miller indices of the reflection of
    /// interest
    /// .Normal: a 1x3 vector defining the direction of the surface normal of the crystal
    /// Probe (optional): a structure data-type containg:
    /// .Type : a string defining the type of probe ('xrays' or 'electrons')
    /// .Energy: energy of the probe in eV
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void StructureFactor(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("StructureFactor", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    ///
    public void VisualizeCrystal()
    {
      mcr.EvaluateFunction(0, "VisualizeCrystal", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    ///
    public void VisualizeCrystal(MWArray Lattice)
    {
      mcr.EvaluateFunction(0, "VisualizeCrystal", Lattice);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Vol">Input argument #2</param>
    ///
    public void VisualizeCrystal(MWArray Lattice, MWArray Vol)
    {
      mcr.EvaluateFunction(0, "VisualizeCrystal", Lattice, Vol);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Vol">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    ///
    public void VisualizeCrystal(MWArray Lattice, MWArray Vol, MWArray FigNum)
    {
      mcr.EvaluateFunction(0, "VisualizeCrystal", Lattice, Vol, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] VisualizeCrystal(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "VisualizeCrystal", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] VisualizeCrystal(int numArgsOut, MWArray Lattice)
    {
      return mcr.EvaluateFunction(numArgsOut, "VisualizeCrystal", Lattice);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Vol">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] VisualizeCrystal(int numArgsOut, MWArray Lattice, MWArray Vol)
    {
      return mcr.EvaluateFunction(numArgsOut, "VisualizeCrystal", Lattice, Vol);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the VisualizeCrystal
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Additional units for the basis
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Lattice">Input argument #1</param>
    /// <param name="Vol">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] VisualizeCrystal(int numArgsOut, MWArray Lattice, MWArray Vol, 
                                MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "VisualizeCrystal", Lattice, Vol, FigNum);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayAttenuationLength()
    {
      return mcr.EvaluateFunction("XrayAttenuationLength", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayAttenuationLength(MWArray Symbol)
    {
      return mcr.EvaluateFunction("XrayAttenuationLength", Symbol);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayAttenuationLength(MWArray Symbol, MWArray Density)
    {
      return mcr.EvaluateFunction("XrayAttenuationLength", Symbol, Density);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayAttenuationLength(MWArray Symbol, MWArray Density, MWArray 
                                   EnergyOrLambda)
    {
      return mcr.EvaluateFunction("XrayAttenuationLength", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayAttenuationLength(MWArray Symbol, MWArray Density, MWArray 
                                   EnergyOrLambda, MWArray alpha)
    {
      return mcr.EvaluateFunction("XrayAttenuationLength", Symbol, Density, EnergyOrLambda, alpha);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayAttenuationLength(MWArray Symbol, MWArray Density, MWArray 
                                   EnergyOrLambda, MWArray alpha, MWArray FigNum)
    {
      return mcr.EvaluateFunction("XrayAttenuationLength", Symbol, Density, EnergyOrLambda, alpha, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayAttenuationLength(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayAttenuationLength", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayAttenuationLength(int numArgsOut, MWArray Symbol)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayAttenuationLength", Symbol);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayAttenuationLength(int numArgsOut, MWArray Symbol, MWArray 
                                     Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayAttenuationLength", Symbol, Density);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayAttenuationLength(int numArgsOut, MWArray Symbol, MWArray 
                                     Density, MWArray EnergyOrLambda)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayAttenuationLength", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayAttenuationLength(int numArgsOut, MWArray Symbol, MWArray 
                                     Density, MWArray EnergyOrLambda, MWArray alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayAttenuationLength", Symbol, Density, EnergyOrLambda, alpha);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the XrayAttenuationLength
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayAttenuationLength(int numArgsOut, MWArray Symbol, MWArray 
                                     Density, MWArray EnergyOrLambda, MWArray alpha, 
                                     MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayAttenuationLength", Symbol, Density, EnergyOrLambda, alpha, FigNum);
    }


    /// <summary>
    /// Provides an interface for the XrayAttenuationLength function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void XrayAttenuationLength(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                            argsIn)
    {
      mcr.EvaluateFunction("XrayAttenuationLength", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayComplexScatteringFactor()
    {
      return mcr.EvaluateFunction("XrayComplexScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayComplexScatteringFactor(MWArray Z)
    {
      return mcr.EvaluateFunction("XrayComplexScatteringFactor", Z);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <param name="Energy">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayComplexScatteringFactor(MWArray Z, MWArray Energy)
    {
      return mcr.EvaluateFunction("XrayComplexScatteringFactor", Z, Energy);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <param name="Energy">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayComplexScatteringFactor(MWArray Z, MWArray Energy, MWArray FigNum)
    {
      return mcr.EvaluateFunction("XrayComplexScatteringFactor", Z, Energy, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayComplexScatteringFactor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayComplexScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayComplexScatteringFactor(int numArgsOut, MWArray Z)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayComplexScatteringFactor", Z);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <param name="Energy">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayComplexScatteringFactor(int numArgsOut, MWArray Z, MWArray 
                                           Energy)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayComplexScatteringFactor", Z, Energy);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the
    /// XrayComplexScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <param name="Energy">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayComplexScatteringFactor(int numArgsOut, MWArray Z, MWArray 
                                           Energy, MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayComplexScatteringFactor", Z, Energy, FigNum);
    }


    /// <summary>
    /// Provides an interface for the XrayComplexScatteringFactor function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// save test.mat Z Energy
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void XrayComplexScatteringFactor(int numArgsOut, ref MWArray[] argsOut, 
                                  MWArray[] argsIn)
    {
      mcr.EvaluateFunction("XrayComplexScatteringFactor", numArgsOut, ref argsOut, 
                                  argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayIndexOfRefraction()
    {
      return mcr.EvaluateFunction("XrayIndexOfRefraction", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayIndexOfRefraction(MWArray Symbol)
    {
      return mcr.EvaluateFunction("XrayIndexOfRefraction", Symbol);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayIndexOfRefraction(MWArray Symbol, MWArray Density)
    {
      return mcr.EvaluateFunction("XrayIndexOfRefraction", Symbol, Density);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayIndexOfRefraction(MWArray Symbol, MWArray Density, MWArray 
                                   EnergyOrLambda)
    {
      return mcr.EvaluateFunction("XrayIndexOfRefraction", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="FigNum">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayIndexOfRefraction(MWArray Symbol, MWArray Density, MWArray 
                                   EnergyOrLambda, MWArray FigNum)
    {
      return mcr.EvaluateFunction("XrayIndexOfRefraction", Symbol, Density, EnergyOrLambda, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayIndexOfRefraction(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayIndexOfRefraction", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayIndexOfRefraction(int numArgsOut, MWArray Symbol)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayIndexOfRefraction", Symbol);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayIndexOfRefraction(int numArgsOut, MWArray Symbol, MWArray 
                                     Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayIndexOfRefraction", Symbol, Density);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayIndexOfRefraction(int numArgsOut, MWArray Symbol, MWArray 
                                     Density, MWArray EnergyOrLambda)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayIndexOfRefraction", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the XrayIndexOfRefraction
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="FigNum">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayIndexOfRefraction(int numArgsOut, MWArray Symbol, MWArray 
                                     Density, MWArray EnergyOrLambda, MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayIndexOfRefraction", Symbol, Density, EnergyOrLambda, FigNum);
    }


    /// <summary>
    /// Provides an interface for the XrayIndexOfRefraction function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void XrayIndexOfRefraction(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                            argsIn)
    {
      mcr.EvaluateFunction("XrayIndexOfRefraction", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the
    /// XrayRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayRealScatteringFactor()
    {
      return mcr.EvaluateFunction("XrayRealScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// XrayRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayRealScatteringFactor(MWArray Z)
    {
      return mcr.EvaluateFunction("XrayRealScatteringFactor", Z);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the
    /// XrayRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayRealScatteringFactor(MWArray Z, MWArray s)
    {
      return mcr.EvaluateFunction("XrayRealScatteringFactor", Z, s);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the
    /// XrayRealScatteringFactor M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayRealScatteringFactor(MWArray Z, MWArray s, MWArray FigNum)
    {
      return mcr.EvaluateFunction("XrayRealScatteringFactor", Z, s, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the XrayRealScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayRealScatteringFactor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayRealScatteringFactor", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the XrayRealScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayRealScatteringFactor(int numArgsOut, MWArray Z)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayRealScatteringFactor", Z);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the XrayRealScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayRealScatteringFactor(int numArgsOut, MWArray Z, MWArray s)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayRealScatteringFactor", Z, s);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the XrayRealScatteringFactor
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Z">Input argument #1</param>
    /// <param name="s">Input argument #2</param>
    /// <param name="FigNum">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayRealScatteringFactor(int numArgsOut, MWArray Z, MWArray s, 
                                        MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayRealScatteringFactor", Z, s, FigNum);
    }


    /// <summary>
    /// Provides an interface for the XrayRealScatteringFactor function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void XrayRealScatteringFactor(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                               argsIn)
    {
      mcr.EvaluateFunction("XrayRealScatteringFactor", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity()
    {
      return mcr.EvaluateFunction("XrayReflectivity", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity(MWArray Symbol)
    {
      return mcr.EvaluateFunction("XrayReflectivity", Symbol);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity(MWArray Symbol, MWArray Density)
    {
      return mcr.EvaluateFunction("XrayReflectivity", Symbol, Density);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda)
    {
      return mcr.EvaluateFunction("XrayReflectivity", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda, MWArray alpha)
    {
      return mcr.EvaluateFunction("XrayReflectivity", Symbol, Density, EnergyOrLambda, alpha);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <param name="kpol">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda, MWArray alpha, MWArray kpol)
    {
      return mcr.EvaluateFunction("XrayReflectivity", Symbol, Density, EnergyOrLambda, alpha, kpol);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <param name="kpol">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayReflectivity(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda, MWArray alpha, MWArray kpol, MWArray FigNum)
    {
      return mcr.EvaluateFunction("XrayReflectivity", Symbol, Density, EnergyOrLambda, alpha, kpol, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut, MWArray Symbol)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", Symbol);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut, MWArray Symbol, MWArray Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", Symbol, Density);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda, MWArray alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", Symbol, Density, EnergyOrLambda, alpha);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <param name="kpol">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda, MWArray alpha, MWArray kpol)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", Symbol, Density, EnergyOrLambda, alpha, kpol);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the XrayReflectivity
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="alpha">Input argument #4</param>
    /// <param name="kpol">Input argument #5</param>
    /// <param name="FigNum">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayReflectivity(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda, MWArray alpha, MWArray kpol, 
                                MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayReflectivity", Symbol, Density, EnergyOrLambda, alpha, kpol, FigNum);
    }


    /// <summary>
    /// Provides an interface for the XrayReflectivity function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void XrayReflectivity(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("XrayReflectivity", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayTransmission()
    {
      return mcr.EvaluateFunction("XrayTransmission", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayTransmission(MWArray Symbol)
    {
      return mcr.EvaluateFunction("XrayTransmission", Symbol);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayTransmission(MWArray Symbol, MWArray Density)
    {
      return mcr.EvaluateFunction("XrayTransmission", Symbol, Density);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayTransmission(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda)
    {
      return mcr.EvaluateFunction("XrayTransmission", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="Thickness">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayTransmission(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda, MWArray Thickness)
    {
      return mcr.EvaluateFunction("XrayTransmission", Symbol, Density, EnergyOrLambda, Thickness);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="Thickness">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray XrayTransmission(MWArray Symbol, MWArray Density, MWArray 
                              EnergyOrLambda, MWArray Thickness, MWArray FigNum)
    {
      return mcr.EvaluateFunction("XrayTransmission", Symbol, Density, EnergyOrLambda, Thickness, FigNum);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayTransmission(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayTransmission", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayTransmission(int numArgsOut, MWArray Symbol)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayTransmission", Symbol);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayTransmission(int numArgsOut, MWArray Symbol, MWArray Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayTransmission", Symbol, Density);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayTransmission(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayTransmission", Symbol, Density, EnergyOrLambda);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="Thickness">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayTransmission(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda, MWArray Thickness)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayTransmission", Symbol, Density, EnergyOrLambda, Thickness);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the XrayTransmission
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Symbol">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="EnergyOrLambda">Input argument #3</param>
    /// <param name="Thickness">Input argument #4</param>
    /// <param name="FigNum">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] XrayTransmission(int numArgsOut, MWArray Symbol, MWArray Density, 
                                MWArray EnergyOrLambda, MWArray Thickness, MWArray FigNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "XrayTransmission", Symbol, Density, EnergyOrLambda, Thickness, FigNum);
    }


    /// <summary>
    /// Provides an interface for the XrayTransmission function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void XrayTransmission(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("XrayTransmission", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
