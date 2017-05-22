
function Lattice = CartesianSystem(Lattice)

NumberOfAtoms = size(Lattice.AtomicPositions, 1);

switch lower(Lattice.Type)
    case 'triclinic'
        a = Lattice.a;
        b = Lattice.b;
        c = Lattice.c;
        alpha = Lattice.alpha*pi/180;
        beta = Lattice.beta*pi/180;
        gamma = Lattice.gamma*pi/180;
        cosa = (cos(alpha)-cos(beta)*cos(gamma))/(sin(beta)*sin(gamma)); % http://homepage2.nifty.com/a-m/bandmemo/node1.html
        sina = sqrt(1-cosa^2);
        Lattice.LatticeVectors = [1 0 0; cos(gamma) sin(gamma) 0; cos(beta) cosa*sin(beta) sina*sin(beta)];
        Lattice.Vc = a*b*c*sqrt(1-cos(alpha)^2-cos(beta)^2-cos(gamma)^2+...
            2*cos(alpha)*cos(beta)*cos(gamma)); % fxsolver.com/browse/formulas/Triclinic+crystal+system+(Unit+cell%27s+volume)
        
    case 'tetragonal'
        Lattice.LatticeVectors = [Lattice.a 0 0; 0 Lattice.a 0; 0 0 Lattice.c];
        Lattice.Vc = Lattice.a^2*Lattice.c*1e-30; % lattice volume
                
    case 'monoclinic' 
        beta = Lattice.beta*pi/180;
        Lattice.LatticeVectors = [Lattice.a 0 0; 0 Lattice.b 0; Lattice.c*cos(beta) 0 Lattice.c*sin(beta)];
        Lattice.Vc = Lattice.a*Lattice.b*Lattice.c*sin(beta)*1e-30;
                
    case 'orthorhombic'
        Lattice.LatticeVectors = [Lattice.a 0 0; 0 Lattice.b 0; 0 0 Lattice.c];
        Lattice.Vc = (Lattice.a*Lattice.b*Lattice.c)*1e-30;
                
    case 'hexagonal'
        Lattice.LatticeVectors = [Lattice.a 0 0; -sin(pi/6)*Lattice.a cos(pi/6)*Lattice.a 0; 0 0 Lattice.c];
        %Lattice.LatticeVectors = [Lattice.a*sin(pi/6) -cos(pi/6)*Lattice.a 0; Lattice.a*sin(pi/6) cos(pi/6)*Lattice.a 0; 0 0 Lattice.c];
        Lattice.Vc = sqrt(3)/2*Lattice.a^2*Lattice.c*1e-30; % unit cell volume = hexagon volume/3
                
    case 'rhombohedral'
        a = Lattice.a;
        alpha = Lattice.alpha*pi/180;
        cosa = (cos(alpha)-(cos(alpha))^2)/(sin(alpha))^2; % http://homepage2.nifty.com/a-m/bandmemo/node1.html
        sina = sqrt(2*cos(alpha)-1);
        Lattice.LatticeVectors = a*[1 0 0; cos(alpha) sin(alpha) 0; cos(alpha) cosa*sin(alpha) sina*sin(alpha)];
        c = sqrt(sum(sum(Lattice.LatticeVectors,1).^2));
        % alternative lattice vetors from http://books.google.se/books?id=zn-se2TKv3QC&pg=PA153&lpg=PA153&dq=rhombohedral+lattice+primitive+vectors&source=bl&ots=JkfbofnHW-&sig=SwgDebuZ_hM4-Yn19fI-DPhGCp0&hl=sv&ei=HhGFS7iQH42C_AbgktHHAg&sa=X&oi=book_result&ct=result&resnum=3&ved=0CBMQ6AEwAg#v=onepage&q=rhombohedral%20lattice%20primitive%20vectors&f=false
        Lattice.LatticeVectors =[a -a/sqrt(3) c;0 2*a/sqrt(3) c; -a -a/sqrt(3) c]/3;
%         Lattice.Vc = a^3*sin(alpha)^2*sina*1e-30;
        Lattice.Vc=a^3*sin(alpha)*sin(alpha/2)*sqrt(3-tan(alpha/2)^2)*1e-30;
    otherwise % cubic
        Lattice.LatticeVectors = [1 0 0; 0 1 0; 0 0 1]*Lattice.a;
        Lattice.Vc = (Lattice.a^3)*1e-30;
end

%% calculate positions in cartesian coordinates
Lattice.AtomicPositionsCartesian = Lattice.AtomicPositions;
for n=1:NumberOfAtoms
    Lattice.AtomicPositionsCartesian(n,:) = sum(repmat(Lattice.AtomicPositions(n,:),[3 1])'.*Lattice.LatticeVectors,1);
end
if isfield(Lattice,'CoordinateSystem')==1 
    if Lattice.CoordinateSystem == 1
        Lattice.AtomicPositionsCartesian = Lattice.AtomicPositions;
    end
end

end
