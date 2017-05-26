# A Quick Introduction to the Diffraction Library

The diffraction library is a collection of MATLAB scripts for the modeling of various diffraction geometries for diffraction of x-rays or electrons from crystals. The library was developed with the Ultrafast Science community in mind, with an emphasis on ease of customization and use. This Quick Intro is targeted towards experienced MATLAB users who wish to quickly learn the key functionalities of the library. It is not intended as an expansive documentation of the library. Further information and examples may be found in the help feature of the respective scripts. The examples below use graphite as the template crystal to showcase the capabilities of the library.

## Build lattice structure

The library currently offers several diffraction scripts corresponding to various diffraction geometries. The minimum neccessary to run a diffraction script is a properly defined lattice structure and a probe (x-rays or electrons). A lattice is constructed by defining the molecular symbol, the lattice system type, the corresponding lattice constants, and the positions of atoms in the lattice (in the reference frame of the lattice system coordinate). The following example shows how to define graphite:

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

The probe is the incident beam. It may currently be defined as either 'xrays' or 'electrons', along with its Energy (in eV). For non-coplanar diffraction, there are additional parameters on the geometry of the incident beam (to be described later). For powder diffraction, only two parameters are required as shown here:

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

GenerateIntensity2theta outputs two figures: The first, shown above, is an Intensity vs. 2theta plot for the given parameters. The second (not shown) is a scatter plot lacking the multiplicity term as to see the individual contributions of a single plane in contrast to the summation of the family of planes.

In addition to the figures, the main output (I) is a table that contains the desired diffraction information such as the diffracted peak intensities, the diffraction angles, and the d-spacings. The table below shows information on the diffraction peaks of graphite up to hkl range of 2.

![sample_powder_table.](sample_powder_table.png)

In addition, the table may be saved as a .txt, .xlsx, .xls, .dat, or .csv depending on the end user's preference. 

## Simulate non-coplanar diffraction from crystals with preferred orientation

This script is useful for simulating the diffraction pattern for 2D layered structures with preferred orientation. The template example is HOPG (graphite), in which the sample surface corresponds to the [001] direction, but in-plane, domains are randomly oriented. This example simulated the geometrical diffraction pattern under grazing incidence off a HOPG crystal. Here, one sees both the brightness and positions of the possible diffraction spots over a range of miller indices given the detector parameters. The additional inputs consist of defining the surface normal, specifying that the probe is incident in a non-coplanar geometry at some incidence angle in degrees (psi) relative to the surface, and, finally, specifying the detector properties and various dimensions (in mm):

```matlab
>> Lattice.Normal = [0 0 1];

>> Probe.Type = 'xrays'
>> Probe.Energy = 20000
>> Probe.DiffractionGeometry = 'noncoplanar';
>> Probe.psi = 0.1;

>> Detector.Shape = 'square'; % may be square or circle
>> Detector.Size = 40;
>> Detector.SpotFWHMx = 2;
>> Detector.SpotFWHMy = 2;
>> Detector.DistanceToSample = 50;
>> Detector.Offset = [0 20];
```
Next, the function generating the simulated diffraction pattern is called:

```matlab
>> I = GeometricalSimulation1(Lattice,Probe,Detector, 0:6,1);
```

The output is a 2D image corresponding to the diffraction pattern on the detector. This is shown below for the above example.    

![sample_xrd_pattern_V2.](sample_xrd_pattern_V2.png)

## Calculate exit angles for non-coplanar diffraction from single-crystals

This also outputs a table to the command window showcasing the desired diffraction information such as the incident and reflected thetas' and psis' in cartesian coordinates, and the calculated angle neccessary to rotate the sample from one peak to another. For the sake of space, a snippet of the table for a miller indice range [0:6] is shown below:

![sample_noncoplanar_table.](sample_noncoplanar_table.png)

## Simulate diffraction pattern in Transmission Election Microscopy.

The library is also capable of simulating geometrical patterns such as the one shown below for TEM diffraction off a crystal. This uses mostly the same parameters from the non-coplanar example.

Most notably, the probe structure once again only requires two variables, Type and Energy:

```matlab
>> Lattice.Normal = [0 0 1];

>> Probe.Type = 'electrons'
>> Probe.Energy = 60000;
```

And as electrons scatter at much smaller angles than xrays and the detector parameters must be adjusted accordingly:
```matlab
>> Detector.Shape = 'square' 
>> Detector.Size = 16  
>> Detector.SpotFWHMx = 0.3
>> Detector.SpotFWHMy = 0.3
>> Detector.DistanceToSample = 200 
>> Detector.Offset = [0 0]
```

Next, we may generate the simulated diffraction pattern via the command-line:

```matlab
>> I = GeometricalSimulation2(Lattice,Probe,Detector, 0:6,1);
```

![sample_TEM_pattern_C.](sample_TEM_pattern_C.png)

## Visualize the lattice structure
As a diagnostic tool, one may also generates a 3D rendering of an inputted lattice structure such as the one shown below for a sodium cloride crystal. 

![sample_VisualizeCrystal_NaCl.](sample_VisualizeCrystal_NaCl.png)

Note: The model shown above was generated using the script Diffraction/VisualizeCrystal.m

