# Empty Platformer project

A platformer made with Unity, with basic mechanics. This repository is for education purposes, so you can use it as a template for you projects.

The main goal of this project is to add as much sign and feedbacks as possible to make a very simple platformer with only the basic moves the most insanely pleaseful to play.

![*Empty Platformer* animated demo](./Docs/images/empty-platformer.gif)

## Rules and allowed moves

### Player

Mechanics:

- Movement
- Jump
- Shoot
- Life points
- Scoring

#### Actions

- Move (left or right)
- Jump
- Shoot (in its movement direction or by using mouse to aim)

**Shoot** action has a cooldown. The duration of that cooldown is up to you. Think about what kind of weapon you want to give to your player ;)

#### Life points

The player has 3 life points. It loses one when it touches an enemy.

You don't need to display life points on UI, but the current health of the player must be showed to him.

#### Score

The score is increased each time an enemy is killed or a collectible is get.

### Enemy action

- Moves from a side of its platform to another
- ... Nothing else.

## Documentation & Howtos

[=> See the complete documentation of the projects components](./Docs/README.md)

### Guides

- [How to set player inputs?](./Docs/howto-inputs.md)
- [How to use events, and react to what happens in the game?](./Docs/howto-events.md)
- [How to work on this project using Git?](./Docs/howto-git.md)

## References

### Games

- [Celeste](https://www.youtube.com/watch?v=70d9irlxiB4)
- [Hollow Knight](www.youtube.com/watch?v=UAO2urG23S4)
- [Hollow Knight (with AK-47 Mod)](https://youtu.be/bq6OJdNcJAw?t=399)
- [King of the Hat](https://www.youtube.com/watch?v=4khBEOIwjyQ)
- [Nuclear Throne](https://www.youtube.com/watch?v=7LSs1bj41P4)
- [Ori and the Blind Forest](https://www.youtube.com/watch?v=cklw-Yu3moE)
- [Overwhelm](https://www.youtube.com/watch?v=yto8PGUWf8U)
- [Syntetik](https://www.youtube.com/watch?v=v5-EYFkf-KU)

### Talks and other references

- [*Juice It Or Lose It* by Martin Jonasson & Petri Purho](https://www.youtube.com/watch?v=Fy0aCDmgnxg)
- [*The Art of Screenshake* by Jan Willem Nijman](https://www.youtube.com/watch?v=AJdEqssNZ-U)
- [*Game Feel* by Steve Swink](http://www.game-feel.com)
- [*How To Prototype a Game in Under 7 Days* by Kyle Gray, Kyle Gabler, Shalin Shodhan & Matt Kucic - Gamasutra](https://www.gamasutra.com/view/feature/2438/how_to_prototype_a_game_in_under_7_.php)
- https://twitter.com/BsMcInnes/status/1228772415683153920

### Recommended tools

- [DOTween](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676): A complete tweening library to create simple animations through code
- [Asset Forge](https://assetforge.io): A 3D software to create models in no time

## Future improvements

- Add ability to aim using the gamepad (by default the right stick)

## Feedback

Did you use this project to train on juiciness? Feel free to send me a demo of the result at [hubert.grossin@gmail.com](mailto:hubert.grossin@gmail.com), I sure will enjoy testing it! ;)

For any other suggestion or issue you encounter on this project, please create an issue on this repository!