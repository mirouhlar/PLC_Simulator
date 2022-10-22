function [q0,q1,q2] = pid2psd(r0,r1,r_1,T)
% funkcia prepocita spojity PID regulator na diskretny PSD regulator pricom
% ako vstupne parametre ocakava koeficienty spojiteho regulatora a perioda
% vzorkovania a na konci overi podmienky ekvivalentnosti 

K = r0;
Ti = r0/r_1;
Td = r1/r0;

q0 = K*(1+T/(2*Ti) + Td/T);
q1 = -K*(1+2*Td/T - T/(2*Ti));
q2 = K*Td/T;

% Podmienky ekvivalentnosti
if (q0 > 0 && q1 < -q0 && -(q0+q1) < q2 && q2 < q0)
    disp("Podmienky ekvivalentnosti su splnene!")
else
    disp("Podmienky ekvivalentnosti su nesplnene!")
end
end