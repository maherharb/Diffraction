% process scattering factor file
clear
home


for z=1:92
    filepath = strcat('dir C:\Users\maher\Documents\Lund\raw\', lower(GetElementSymbol(z)), '.nff');
    [s, w] = dos(filepath);
    if s==0
        filepath = strcat('C:\Users\maher\Documents\Lund\raw\', lower(GetElementSymbol(z)), '.nff');
        [h, sf] = hdrload(filepath);
        save(strcat('C:\Users\maher\Documents\Lund\raw\xray_sf_', num2str(z) ,'.mat'), 'sf');
    end
end


