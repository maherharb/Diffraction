# A Quick Introduction to the Diffraction Library

The diffraction library is a collection of MATLAB scripts used for the modeling of various diffraction geometries for diffraction of x-rays or electrons from crystals. The library was developed with the Ultrafast Science community in mind, with an emphasis on ease of customization and use. This Quick Intro is targeted towards experienced MATLAB users who wish to quickly learn the key functionalities of the library. It is not intended as an expansive documentation of the library. Further information and examples may be found in the help feature of the respective scripts. The examples below use graphite as the template crystal to showcase the capabilities of the library.

## Build lattice structure

The library currently offers several diffraction scripts corresponding to various diffraction geometries. The minimum information neccessary to run a diffraction script is a properly defined lattice structure and a probe beam (x-rays or electrons). A lattice is constructed by defining the molecular symbol, the lattice system type, the corresponding lattice constants (dimensions in Ångströms and angles in degrees), and the positions of atoms in the lattice (in the reference frame of the lattice system coordinate). The following example shows how to define graphite:

```matlab
>> Lattice.Symbol = 'C';   
>> Lattice.Type = 'hexagonal'; 
>> Lattice.a = 2.4560;
>> Lattice.c = 6.6960;
>> Lattice.AtomicPositions = [0 0 0 ; 0 0 1/2 ; 1/3 2/3 0 ; 2/3 1/3 1/2];
```

Once defined, the user can save the lattice structure as a MATLAB file so as not to have to redefine it again in the future. This is done by using the save commad in MATLAB:

```matlab
>> save('graphite_hexagonal.mat', 'Lattice'); 
```
All other lattice properties, if not defined in the structure file, are automatically calculated by the library (e.g. lattice volume, density, etc.).

## Define probe

The probe is the incident beam. It may currently be defined as either 'xrays' or 'electrons', along with its Energy (in eV). For non-coplanar diffraction, there are additional parameters on the geometry of the incident beam (to be described later). For powder diffraction, only two parameters are required as shown in this example:

```matlab
>> Probe.Type = 'xrays';
>> Probe.Energy = 8048.3;
```

## Generate powder diffraction profile

With 'Lattice' and 'Probe' defined, one can now run the powder diffraction simulation with the above inputs via the MATLAB command-line:

```matlab
>> I = GenerateIntensity2theta(Lattice, Probe);
```

![sample_powder_diffraction.](sample_powder_diffraction.png)

GenerateIntensity2theta outputs two figures: The first, shown above, is an Intensity vs. 2theta plot for the given lattice structure and probe beam. The second (not shown) is a scatter plot in which the multiplicity term was not factored into the Intensity calculation as to highlight the individual contributions of a single plane in contrast to the summation of intensities across a family of planes.

In addition to these figures, the main output is a table that contains useful diffraction information such as the diffracted peak intensities, the diffraction angles, the scattering vectors, and the d-spacings. The table below shows information on the diffraction peaks of graphite up to hkl range of 2 (the hkl range is an optional parameter to the GenerateIntensity2theta function).

![sample_powder_table.](sample_powder_table.png)

In addition, the table above may be saved as a .txt, .xlsx, .xls, .dat, or .csv depending on the end user's preference. 

## Simulate noncoplanar diffraction from crystals with preferred orientation

This script is useful for simulating the diffraction pattern for 2D layered structures with preferred orientation. The template example is Highly oriented pyrolytic graphite (HOPG), in which the sample surface corresponds to the [001] direction, but in-plane, domains are randomly oriented. The example below is a simulation of the geometrical diffraction pattern under grazing incidence off an HOPG crystal. Here, one sees both the brightness and positions of the possible diffraction spots over a range of miller indices for a given detector geometry. The additional inputs consist of defining the surface normal of the crystal, specifying that the probe is incident in a noncoplanar geometry at some incidence angle, psi, in degrees relative to the surface, and, finally, specifying the detector shape and dimensions (in mm):

```matlab
>> load('graphite_hexagonal.mat');
>> Lattice.Normal = [0 0 1];

>> Probe.Type = 'xrays';
>> Probe.Energy = 20000;
>> Probe.DiffractionGeometry = 'noncoplanar';
>> Probe.psi = 0.1;

>> Detector.Shape = 'square';
>> Detector.Size = 40;
>> Detector.SpotFWHMx = 2;
>> Detector.SpotFWHMy = 2;
>> Detector.DistanceToSample = 50;
>> Detector.Offset = [0 20];
```
Next, the function generating the simulated diffraction pattern is called:

```matlab
>> I = GeometricalSimulation1(Lattice, Probe, Detector, 0:6, 1);
```

The output, I, is a 2D image corresponding to the diffraction pattern on the detector. This is shown below for the above example.    

![sample_xrd_pattern_V2.](sample_xrd_pattern_V2.png)

## Calculate exit angles for noncoplanar diffraction from single-crystals

In addition to the simulated diffraction pattern, the noncoplanar script outputs a table listing useful diffraction information on the noncoplanar geometry. This information includes the incident and reflected angles both azimuthally and relative to the sample surface. An example of calling this function is shown below (because of the limited space, only a snippet of the table for miller indices range up to 6 is included).

![sample_noncoplanar_table.](sample_noncoplanar_table.png)

## Simulate diffraction pattern in Transmission Election Microscopy.

This script is used for simulating geometrical pattern for electron diffraction in a transmission geometry as shown below. TThe syntax is very similar to the noncoplanar geometry.

```matlab
>> load('graphite_hexagonal.mat');
>> Lattice.Normal = [0 0 1];

>> Probe.Type = 'electrons';
>> Probe.Energy = 60000;

>> Detector.Shape = 'square'; 
>> Detector.Size = 16;  
>> Detector.SpotFWHMx = 0.3;
>> Detector.SpotFWHMy = 0.3;
>> Detector.DistanceToSample = 200; 
>> Detector.Offset = [0 0];
```

Next, the function generating the simulated diffraction pattern is called:

```matlab
>> I = GeometricalSimulation2(Lattice,Probe,Detector, 0:6,1);
```

![sample_TEM_pattern_C.](sample_TEM_pattern_C.png)

## Visualize the lattice structure
As a diagnostic tool, one may also generate a 3D rendering of a lattice structure such as the one shown below for sodium cloride: 

```matlab
>> Lattice.Symbol = 'NaCl';
>> Lattice.Type = 'cubic';
>> Lattice.a = 5.6402;
>> Lattice.AtomicTypes = [1,1,1,1,2,2,2,2]
>> AtomicPositions = [ 0 0 0 ; 1/2 1/2 0 ; 1/2 0 1/2 ; 0 1/2 1/2 ; 1/2 1/2 1/2 ; 0 0 1/2 ; 0 1/2 0 ; 1/2 0 0 ]

>> VisualizeCrystal(Lattice)
```

![sample_VisualizeCrystal_NaCl.](sample_VisualizeCrystal_NaCl.png)


