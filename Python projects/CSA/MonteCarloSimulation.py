import random

# Used to solve the Gamblers Ruin statistical problem.

stake = int(input())
goal = int(input())
trials = int(input())

bets = 0
wins = 0
loss = 0

for i in range(trials):
    money = stake
    while (money > 0 and money < goal):
        bets += 1
        if (random.randint(0, 1) < 1):
            money += 1
        else:
            money -= 1
    if (money == goal):
        wins += 1
    else:
        loss -= 1

print(str(wins) + " / " + str(trials))
print("Percent of games won = " + str(100 * wins / trials))
print("Average number of bets = " + str(1.0 * bets / trials))