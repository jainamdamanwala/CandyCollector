Here’s a complete `README.md` for your **2D Candy Collector** game:

---

# 🍬 **Candy Collector** 🕹️  
**A Sweet Adventure of Physics and Puzzles!**

Welcome to **Candy Collector**, a physics-based 2D game where players must navigate ropes, bubbles, and dynamic obstacles to collect delicious candies! Inspired by the beloved "Cut the Rope" series, this game challenges your problem-solving skills with exciting mechanics and interactive levels. Are you ready to become the ultimate candy collector? 🍭

---

## **🌟 Features**
- **Physics-Based Gameplay**: Swing, float, and drag your way to victory using realistic physics mechanics.
- **Interactive Ropes**: Cut ropes dynamically to guide the candy into the player’s reach.
- **Bubbles & Sliders**: Use bubbles to float, sliders to maneuver obstacles, and clever timing to succeed.
- **Teleportation Portals**: Jump through portals to reach different areas of the level.
- **Dynamic Level Progression**: Transition smoothly between levels with increasing challenges.
- **Beautiful 2D Design**: Simple yet elegant visuals that immerse you in a candy-filled world.

---

## **🎮 How to Play**
1. **Interact** with the environment: cut ropes, move sliders, and use bubbles to guide the candy.
2. **Collect the Candy**: Reach the collectible to complete each level.
3. **Navigate Obstacles**: Use portals, ropes, and physics objects strategically.
4. Progress through levels for increasing complexity and new mechanics.

---

## **📂 Repository Structure**
```
CandyCollector/
├── Assets/
│   ├── Scripts/
│   │   ├── Collectible.cs          # Handles candy collection
│   │   ├── RopeCutter.cs          # Enables cutting of rope links
│   │   ├── Rope.cs                # Manages rope generation and physics
│   │   ├── Weight.cs              # Connects weights to the rope's end
│   │   ├── bubble.cs              # Adds bubble physics for floating mechanics
│   │   ├── Slider.cs              # Implements draggable sliders
│   │   ├── CandyMachine.cs        # Triggers level transitions
│   │   ├── DragFingerMove.cs      # Allows dragging of objects
│   │   ├── Teleportation.cs       # Handles player teleportation
│   │   ├── SimpleCameraController.cs # Smooth camera controls
├── README.md                      # Project details and instructions
```

---

## **🔧 Code Overview**

### **Key Scripts**

#### **Collectible.cs**
- Handles the candy collectible behavior.
- Detects collisions with the player and destroys the candy upon collection.

#### **RopeCutter.cs**
- Enables players to cut specific rope links by clicking or tapping.
- Uses raycasting to detect player interactions with `Link` objects.

#### **Rope.cs**
- Dynamically generates ropes at runtime using multiple connected links.
- The rope interacts with physics objects, and the final link connects to a weight for realistic swinging mechanics.

#### **Weight.cs**
- Attaches the rope's last link to a weighted object.
- Handles dynamic physics-based interactions.

#### **bubble.cs**
- Allows the player to float using a bubble with reduced gravity.
- Removes the bubble and restores gravity upon interaction.

#### **Slider.cs**
- Implements draggable sliders that players can move horizontally.
- Useful for navigating obstacles or positioning objects.

#### **CandyMachine.cs**
- Triggers a level transition when the player interacts with the candy machine.
- Delays the transition to create a smoother effect.

#### **DragFingerMove.cs**
- Enables dragging of objects using touch or mouse input.
- Calculates the direction and applies smooth velocity for movement.

#### **Teleportation.cs**
- Handles teleportation mechanics for the player.
- Moves the player to a portal's position after a slight delay.

#### **SimpleCameraController.cs**
- Provides smooth camera translation and zooming capabilities.
- Allows level designers to customize camera speed and movement constraints.

---

## **📸 Screenshots & Gameplay**
<div>
    <img src="https://github.com/jainamdamanwala/CandyCollector/blob/main/CandyCollector_SS/Screenshot%202025-01-28%20012543.png" width = 49%/>
    <img src="https://github.com/jainamdamanwala/CandyCollector/blob/main/CandyCollector_SS/Screenshot%202025-01-28%20012600.png" width = 49%/>
    <img src="https://github.com/jainamdamanwala/CandyCollector/blob/main/CandyCollector_SS/Screenshot%202025-01-28%20012618.png" width = 49%/>
    <img src="https://github.com/jainamdamanwala/CandyCollector/blob/main/CandyCollector_SS/Screenshot%202025-01-28%20012629.png" width = 49%/>
</div>

### **Gameplay Video**
## Watch the Gameplay video on Youtube  
<br align = center>
<a href = "https://youtube.com/shorts/oW8JKfgNey8?feature=share"><img src="https://img.shields.io/static/v1?message=Youtube&logo=youtube&label=&color=FF0000&logoColor=white&labelColor=&style=for-the-badge" height="35" alt="youtube logo"  /></a> 
</br>

[![Gameplay Video](https://github.com/jainamdamanwala/CandyCollector/blob/main/CandyCollector_SS/Screenshot%202025-01-28%20012543.png)](https://youtube.com/shorts/oW8JKfgNey8?feature=share)
---

## **💻 Tech Stack**
- **Engine**: Unity 2D  
- **Programming Language**: C#  
- **Platform**: PC, Mobile  

---

## **🛠 Future Enhancements**
- Add more complex level designs with new obstacles and interactive elements.
- Introduce a scoring system based on time and moves used.
- Implement player achievements and a global leaderboard.

---

## **📜 License**
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## **🌟 Join the Sweet Adventure!**
Download **Candy Collector** and enjoy hours of engaging, physics-based fun. Challenge your friends to see who can collect the most candies and master the game's mechanics!

---

Let me know if you'd like to make adjustments or add more details! 🚀
