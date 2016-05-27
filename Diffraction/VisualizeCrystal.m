function VisualizeCrystal(Lattice, Vol, FigNum)

pltColor = 'rbgcmy';

if nargin<2
    Vol = [-5 5;-5 5;-5 5];
end

if nargin<3
    FigNum = 1;
end

Lattice = CartesianSystem(Lattice);

[rx,ry,rz] = sphere(8);

rx = rx*0.5; ry = ry*0.5; rz = rz*0.5;

% Additional units for the basis
T = [];
for i=1:size(Lattice.AtomicPositions,1)
    T = [T; Lattice.AtomicPositionsCartesian(i,:)];
end

% Translation in the a1-axis
count = 1;
for i = -10:10
    for j = -10:10
        for k = -10:10
            for l =1:size(T,1)
                x = T(l,1) + i*Lattice.LatticeVectors(1,1) + j*Lattice.LatticeVectors(2,1) + k*Lattice.LatticeVectors(3,1);
                y = T(l,2) + i*Lattice.LatticeVectors(1,2) + j*Lattice.LatticeVectors(2,2) + k*Lattice.LatticeVectors(3,2);
                z = T(l,3) + i*Lattice.LatticeVectors(1,3) + j*Lattice.LatticeVectors(2,3) + k*Lattice.LatticeVectors(3,3);
                if x>=Vol(1,1) && y>=Vol(2,1) && z>=Vol(3,1) && x<=Vol(1,2) && y<=Vol(2,2) && z<=Vol(3,2)
                    M(count,:) = T(l,:) + i*Lattice.LatticeVectors(1,:) +j*Lattice.LatticeVectors(2,:) +k*Lattice.LatticeVectors(3,:);
                    if isfield(Lattice,'AtomicTypes')==1
                        Type(count) = Lattice.AtomicTypes(l);
                    else
                        Type(count) = 1;
                    end
                    count = count+1;
                end
            end
        end
    end
end


if exist('M')==1
    % find nearest neighbor distance
    bond_dist = 1e10;
    for i=1:size(T,1)
        for j=1:size(M,1)
            d = sqrt(sum((T(i,:)-M(j,:)).^2));
            if d>1e-5
                bond_dist = min(d,bond_dist);
            end
        end
    end


    % Plotting the points (basis coordinates)
    figure(FigNum)
    hold off
    for i=1:size(M,1)
        p = 1 ;
        if Type(i)<7
            p = Type(i);
        end
        surf(rx+M(i,1), ry+M(i,2), rz+M(i,3),'FaceColor', pltColor(p),'EdgeColor','none');
        view(10, 12)
        hold on;
    end
    camlight left; lighting phong;
    box on

    for i=1:size(M,1)
        for j=1:size(M,1)
            if i~=j
                dist = sqrt((M(i,1)-M(j,1))^2 + (M(i,2)-M(j,2))^2 + (M(i,3)-M(j,3))^2);
                if dist>bond_dist*0.95 && dist<bond_dist*1.05
                    plot3([M(i,1) M(j,1)], [M(i,2) M(j,2)], [M(i,3) M(j,3)], 'k', 'LineWidth', 2)
                end
            end
        end
    end

    camlight left; lighting phong;grid off,
    box on

    str='';

    
    
    if isfield(Lattice,'Z')==0 
        [Lattice.Z N] = ParseChemicalSymbol(Lattice.Symbol);
    end 
    
    for i=1:size(Lattice.Z,2)
        clr = '';
        switch i
            case 1
                 clr = 'red';
            case 2
                 clr = 'blue';
            case 3
                 clr = 'green';
            case 4
                 clr = 'cyan';
            case 5
                 clr = 'magenta';
            case 6
                 clr = 'yellow';
            case default
                 clr = 'red';
        end

        str = strcat([str, GetElementSymbol(Lattice.Z(i)), '=', clr, ', ']);
    end

  %  title(strcat([str, ' nnd=',  num2str(bond_dist), ' A']))
%  title('Graphite','FontSize', 18 )
    axis([Vol(1,1)-1 Vol(1,2)+1 Vol(2,1)-1 Vol(2,2)+1 Vol(3,1)-1 Vol(3,2)+1])
     set(gca,'XTick',[])
    set(gca,'YTick',[])
     set(gca,'ZTick',[])
set(gca,'visible','off')
end
