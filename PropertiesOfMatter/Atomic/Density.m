% DENSITY Calculate the density of the lattice in g/cm3.
%
% DENSITY(LATTICE)
%       LATTICE is a structure data-type containing:
%             .Symbol: Chemical symbol of the molecule
%               .Type: 'cubic', 'tetragonal', 'orthorhombic', 'hexagonal', 'rhombohedral', 'monoclinic', 'triclinic'
%            .a .b .c: lattice constants in Angstroms (depending on lattice type some of these are not needed)
% .alpha .beta .gamma: lattice constants in degrees (depending on lattice type some of these are not needed)
%   .CoordinateSystem: (optional) 1 (default) for lattice coordinate system, 0 for cartesian coordinate system
%    .AtomicPositions: n by 3  matrix, each row represents atomic coordinates
%        .AtomicTypes: (optional) 1xn vector defining the type of the atom for each row of the AtomicPositions Matrix
%
% Example 1 (lattice defined from scartch):
%   Lattice.Symbol = 'Au';
%   Lattice.Type = 'cubic';
%   Lattice.a = 4.08;
%   Lattice.AtomicPositions = [0 0 0; 0.5 0.5 0; 0.5 0 0.5; 0 0.5 0.5];
%   Density(Lattice)
%
% Exampe 2 (lattice loaded from structure library):
%   load Au.mat
%   Density(Lattice)
%
% Last update: 06-03-2011, Maher Harb

function rho = Density(Lattice)

    AMU = 1.66053886e-27; % [Kg]
    
    NumberOfAtoms = size(Lattice.AtomicPositions, 1);
    
    if isfield(Lattice,'Z')==0 
        if isfield(Lattice,'Symbol')==1 
            [Lattice.Z N] = ParseChemicalSymbol(Lattice.Symbol);
            if length(Lattice.Z)>1 % molecule
                Lattice.N = N;
            end
        else
            rho = 0;
            error('Lattice not sufficiently defined. Type "help Density" to learn more.')
        end
    end
    
    if isfield(Lattice,'Vc')==0
        Lattice = CartesianSystem(Lattice);
    end
    
    if length(Lattice.Z)==1
        rho = AMU*GetAtomicMass(Lattice.Z)*NumberOfAtoms/Lattice.Vc/1000; % [g/cm3] 
    else
        rho = AMU*sum(GetAtomicMass(Lattice.Z(Lattice.AtomicTypes)))/Lattice.Vc/1000; % [g/cm3]
    end

end