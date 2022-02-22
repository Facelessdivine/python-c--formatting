^+!1::
Loop
{
    FileReadLine, entiti, entities.txt, %A_Index%
    FileReadLine, config, configurations.txt, %A_Index%
    if ErrorLevel
        break
    sendInput, ^{f}
    sleep, 600
    sendInput, 'config/
    Clipboard= 'config/%config%'
    sleep, 500
    sendInput, {esc 2}
    sleep, 250
    sendInput, {ctrl down}{left}{ctrl up}{left}
    sleep, 100
    sendInput, {ctrl down}{shift down}{right 4}{ctrl up}{right}{shift up}
    sleep, 50
    sendInput, {ctrl down}{d 2}{ctrl up}
    sendInput, {ctrl down}{v}{ctrl up}
    sleep, 100
    sendInput, ^{f}
    sleep, 600
    sendInput, 'entities/
    Clipboard= 'entities/%entiti%'
    sleep, 500
    sendInput, {esc 2}
    sleep, 350
    sendInput, {ctrl down}{left}{ctrl up}{left}
    sleep, 200
    sendInput, {ctrl down}{shift down}{right 4}{ctrl up}{right}{shift up}
    sendInput, {ctrl down}{v}{ctrl up}
    sleep, 500
    sendInput, ^{s}
    sleep, 300
    sendInput, {ctrl down}{shift down}{,}{shift up}{ctrl up}
    sleep, 400
    sendInput, py script.py
    sendInput, {enter}
    sleep, 3000
    sendInput, {ctrl down}{shift down}{,}{shift up}{ctrl up}
    sleep, 1000
}
Return

^+r::reload