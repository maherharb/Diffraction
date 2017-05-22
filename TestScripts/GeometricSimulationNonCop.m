% Generate a table of values for the angles for the incident and reflected
% beam.
% Asks what type of file extension the end user would like the file saved
% in, runs through the hardcoded hkl range in the main form script being
% used, and records:
% The hkl plane the peak occurs at
% The incident Theta and Psi in spherical space
% The reflected Theta and Psi in spherical space
% The incident vector in cartesian space
% The reflected vector in cartesian space

function Table=GeometricSimulationNonCop(Lattice, Probe,Detector, hkl_space)
% Check what kind of file does the user want.

TypeOfFile=input('What kind of file extension do you want? Options: none, txt, xlsx, xls, dat, csv \n','s');

index=1;
for h=hkl_space
    for k=hkl_space
        for l=hkl_space
            if h==0 && k==0 && l==0 
            else
                Lattice.Reflection=[h k l];
                [SF,Lattice, Probe]=StructureFactor(Lattice,Probe);
                if isreal(SF.BraggAngle)==1 && SF.Intensity>10^-10
                    Result=NonCoplanarDiffraction(SF.BraggAngle, Probe.psi,SF.CrystalNormal,SF.ReflectionNormal);
                    % Make struct variable to store the values from
                    % NonCoplanarDiffraction
                    if isreal(Result.Incident)&& isreal(Result.IncidentSpherical) && ...
                            isreal(Result.Reflected) && isreal(Result.ReflectedSpherical) &&...
                            atand(Detector.Size/2/Detector.DistanceToSample)>abs(Result.IncidentSpherical(1))
                        % Added check for the angle of view to the detector
                        % to be bigger than the absolute angle of incidence
                        % theta.
                        Table.h=h;
                        Table.k=k;
                        Table.l=l;
                        Table.Incident_Theta=Result.IncidentSpherical(1);
                        Table.Incident_Psi=Result.IncidentSpherical(2);
                        Table.Reflected_Theta=Result.ReflectedSpherical(1);
                        Table.Reflected_Psi=Result.ReflectedSpherical(2);
                        Table.IncidentX=Result.Incident(1);
                        Table.IncidentY=Result.Incident(2);
                        Table.IncidentZ=Result.Incident(3);
                        Table.ReflectedX=Result.Reflected(1);
                        Table.ReflectedY=Result.Reflected(2);
                        Table.ReflectedZ=Result.Reflected(3);
                        Array(index)=Table;
                        
                        index=index+1;
                    end
                end
            end
        end
    end
end
Table=struct2table(Array);
if size(TypeOfFile,2)==4
    if TypeOfFile=='xlsx'
        Name=strcat(Lattice.Symbol,'_',Lattice.Type,'_','XRD_spherical_angles.xlsx');
        writetable(Table,Name);
    end
elseif size(TypeOfFile,2)==3
    if TypeOfFile== 'txt'
        Name=strcat(Lattice.Symbol,'_',Lattice.Type,'_','XRD_spherical_angles.txt');
        writetable(Table,Name);
    elseif TypeOfFile=='dat'
        Name=strcat(Lattice.Symbol,'_',Lattice.Type,'_','XRD_spherical_angles.dat');
        writetable(Table,Name);
    elseif TypeOfFile == 'csv'
        Name=strcat(Lattice.Symbol,'_',Lattice.Type,'_','XRD_spherical_angles.csv');
        writetable(Table,Name);
    elseif TypeOfFile == 'xls'
        Name=strcat(Lattice.Symbol,'_',Lattice.Type,'_','XRD_spherical_angles.xls');
        writetable(Table,Name);
    end
else %default do nothing, just outputs as a matlab variable table
end




