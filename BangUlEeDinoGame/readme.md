# open-source-project_games2
# BangUlEe Dino game, 방울이 공룡게임

유니티를 활용하여 저희 집 고양이 방울이를 테마로 방울이가 점프하는 게임을 개발하였습니다.  

https://user-images.githubusercontent.com/49617190/206883762-3cb0fe74-a066-4e1f-b07e-b0bf29ff1b2d.mp4


게임플레이 영상입니다

---

## 목차

1. [프로젝트 기획 이유](#프로젝트-기획-이유)
2. [게임설명](#게임설명)
3. [에셋 설명](#에셋설명)
4. [코드설명](#코드설명)
5. [플레이하는법- 스크린샷](#플레이하는법--스크린샷)
6. [리뷰피드백](#리뷰피드백)
7. [릴리즈](#릴리즈)
8. [느낀점](#느낀점)
9. [참고한곳](#참고한곳)
10. [라이센스](#라이센스)

---

## 📝프로젝트 기획 이유
<img src="https://user-images.githubusercontent.com/49617190/204704448-6c2ea206-b5cb-454a-acaa-9dc55741fdbf.png"  width="500" height="700">  

저희집 고양이 방울이 입니다.

<img src="https://user-images.githubusercontent.com/49617190/204705259-c445467c-a907-4c8a-93b7-3f2c0fbfc6e6.gif"  width="500" height="500">   


평소에 유니티로 게임 개발하는 것에 관심이 많았었는 데 어떤 주제로 게임을 만들지 고민하다가 집에서 방울이가 점프하는 것을 보고 이를 주제로 게임을 만들면 재미있겠다는 생각이 들어서 이러한 프로젝트를 기획하게 되었습니다. 

---
## 📝게임설명
구글 크롬의 인터넷연결이 되지 않을 때 나오는 미니게임인 다이노 게임을 모티브로 우리집 고양이인 방울이가 장애물을 피해 점프하는 게임을 만든다.   
방울이 캐릭터를 스페이스바를 눌러 점프해서 장애물을 피해 점수를 얻어 최대한 많은 점수를 획득하는 게임입니다.    
게임이 진행될수록 속도가 빨라지며 속도에 따라 점수도 빨리 올라간다.  
*크롬 공룡 게임을 참고하였습니다.  

---

## 📝에셋설명

### 이미지
![New Piskel (1)](https://user-images.githubusercontent.com/49617190/205010430-9ca41e88-530f-42d6-9ba9-a21a361fb772.png)  
도트 찍는 프로그램을 통해 캐릭터를 자체 제작하였습니다

![image](https://user-images.githubusercontent.com/49617190/205010935-dc34bc39-709a-4c7b-be81-4463f0a4e59c.png)  
도트 찍는 프로그램을 통해 에셋-땅을 자체 제작하였습니다

### 사운드 에셋 출처
무료로 사용가능한 곳에서 다운 받아 사용했습니다.
https://soundeffect-lab.info/sound/button/

---

## 📝코드설명
![image](https://user-images.githubusercontent.com/49617190/206884022-24b31927-a861-4273-935c-e635ca4aa163.png)  
player.cs 코드입니다.  
bool isGround로 캐릭터가 땅에 붙어있는지 확인합니다.
Input.GetKeyDown으로 스페이스키를 누르면 Force만큼 캐릭터를 점프시킵니다. 이때 땅에서 떨어지므로 isGround를 false로 해줍니다.  
OnCollisionEnter2D에서는 캐릭터가 닿은 에셋의 태그가 Ground면 다시 땅에 붙은 것이므로 isGround를 true로 변경합니다. 

![image](https://user-images.githubusercontent.com/49617190/206884304-e9c24a2e-3bbd-4720-9938-580af6fb525e.png)  
wall.cs 코드입니다.  
speed: 속도값을 저장하는 변수  
Ground: 땅 오브젝트를 담고있는 변수 
wall: 장애물에 대한 변수  
score: 점수에 대한 변수  
score_cnt: 올라가는 점수를 저장할 변수
speed += 0.1f*Time.deltaTime; 를 통해서 시간이 지남에 따라 속도를 점점 빠르게 만들어 줍니다.  
score_cnt+=1 을 통해 점수를 계속 증가시킵니다.
transform 함수를 통해 장애물을 계속 생성하고 위치를 초기화하게 만듭니다
for문을 통해 아래 ground 애셋을 계속 이동시키는 애니메이션 효과를 줍니다.  
move함수를 통해 장애물을 이동시킵니다.

---

## 📝플레이하는법- 스크린샷

이 레포지토리의 릴리즈에서 최신 버전인 v2.0.0을 다운로드해서 zip파일을 압축해제하고 BangUlEeDinogame.exe파일을 실행시키면 플레이 가능합니다.


<img src="https://user-images.githubusercontent.com/49617190/206883779-04e9690d-ee64-4251-8ada-f48edb506bdf.png"  width="1000" height="700">     

게임 플레이 화면입니다 화면 제일 오른쪽에는 게임의 스코어가 나오도록 만들었고 고양이 캐릭터를 터치하면 위로 점프합니다. 랜덤 생성되는 장애물을 피해서 앞으로 진행하면 됩니다.
캐릭터가 점프하면 효과음이 나오게 되고 캐릭터가 장애물과 충돌하면 효과음과 함께 게임이 종료하게 됩니다.  
게임의 진행속도는 갈수록 빨라집니다.
게임의 점수는 갈수록 빠르게 올라갑니다.   

## 📝리뷰피드백
| 리뷰,피드백    | 별점      |
|-----------|------------|
| 게임 난이도가 어렵다, 게임은 재미있다 | 5/5 |
| 디자인이 아쉽다. 디자인은 디자이너에게 | 4/5 |
| 갈수록 게임의 속도가 빨라져서 재미있다. | 4/5 |
| 재시작 버튼이 있으면 게임을 바로 재시작할 수 있어서 좋을 것 같다. | 4/5 |

---

## 📝릴리즈
v1.0.0: 게임의 첫번째 버전입니다.

v2.0.0: 게임의 현재 최신 업데이트 버전 입니다. 피드백을 반영하여 수정하였고 업데이트 내역입니다.
-BangUlEeDinogame 게임 다시 제작  
-어색한 에셋 수정  
-캐릭터가 바닥에 닿아있을 경우에만 점프가능하게 수정  
-시간에 따라서 속도 빨라지게 수정  
-시간에 따라서 점수 올라가는 속도 빨라지게 수정  
-점프 방식을 마우스 클릭에서 스페이스 키로 변경  
-컴퓨터에서 exe파일을 통해 정상적으로 플레이 가능하게 수정  
-기타 오류, 어색한 부분, 버그 수정이되었습니다.   
이 릴리즈를 설치해 게임을 플레이하시면 됩니다.  

추후 업데이트 예정사항
<img src="https://user-images.githubusercontent.com/49617190/206876072-e7efb84e-4974-4e5a-923f-2c27bdd61df5.png"  width="400" height="400">  
장애물-새를 추가하여서 땅에서는 선인장 장애물을 피하도록 하고 하늘에서는 새 장애물을 피하도록 만들어서 게임을 더 어렵고 생동감 있게 만드는 업데이트를 추후 추가할 예정입니다.  
게임내에서 바로 게임을 재시작 할 수 있도록 재시작 버튼을 추가할 에정입니다.  

---


## 📝느낀점
오픈소스 프로젝트로 처음 BangUlEeFlappybird게임을 만들고 유니티로 게임을 만드는 것에 더 재미가 생겨서 게임을 하나 더 만들어 보고 싶어져서 제작하게 되었습니다. 추후에 재시작 기능과 다른 장애물까지 추가할 계획이고 게임기획과 디자인을 공부해서 내년에는 저 혼자 인디게임개발대회에 저의 작품을 출품해보고 싶다는 각오가 생겼습니다.

---
## 📝참고한곳
무료 쉬운 게임 개발 강의 - 3시간만에 개발, 출시, 수익화까지 완성 - https://www.youtube.com/watch?v=EqoU1PodQQ4&t=6591s    
공룡게임 3분 제작 https://www.youtube.com/watch?v=bpAhWPQxMss   
나무위키 공룡게임 https://namu.wiki/w/Chrome/%EC%9D%B4%EC%8A%A4%ED%84%B0%20%EC%97%90%EA%B7%B8  



## 📝라이센스
MIT License를 따릅니다. 레포지토리 안에 license.md파일을 만들어 두었습니다.

### 📝게임 시연 영상 ###
https://www.youtube.com/shorts/A_zOd4DcTT0

## 🖥️Developers
19101191 김경준


<hr>
## This is a manual for English speakers
Using Unity, we developed a game where rattles jump under the theme of our cat BangUl

https://user-images.githubusercontent.com/49617190/206883762-3cb0fe74-a066-4e1f-b07e-b0bf29ff1b2d.mp4


It's a game play video

---

## Table of Contents

1. [Reason for project planning] (#Project-Planning-Reason)
2. [Game explanation] (#Game explanation)
3. [Explanation of Asset] (#Explanation of Asset)
4. [Code Description] (#Code Description)
5. [How to play - Screenshot] (#How to play - Screenshot)
6. [Review feedback] (#Review feedback)
7. [Release] (#Release)
8. [Feeling] (#Feeling)
9. [Reference] (#Reference)
10. [License] (#License)

---

## 📝 Reasons for project planning
<img src="https://user-images.githubusercontent.com/49617190/204704448-6c2ea206-b5cb-454a-acaa-9dc55741fdbf.png" width="500" height="700">

This is my cat, BangUl.

<img src="https://user-images.githubusercontent.com/49617190/204705259-c445467c-a907-4c8a-93b7-3f2c0fbfc6e6.gif" width="500" height="500">


I was interested in developing a game with Unity. Usually, I was thinking about what topic to make a game, and I thought it would be fun to make a game with this topic after seeing a rattles jump at home.

---
## 📝 Game description
Based on the motif of the Dino game, a mini game that comes out when Google Chrome is not connected to the Internet, our cat, Bell, makes a game that jumps to avoid obstacles.
It's a game in which the bell presses the space bar to jump to avoid obstacles and score as many points as possible.
As the game progresses, the speed increases, and the score increases faster depending on the speed.
*Refer to Chrome dinosaur game.

---

## 📝 Asset Description

### Image
![New Piskel (1)](https://user-images.githubusercontent.com/49617190/205010430-9ca41e88-530f-42d6-9ba9-a21a361fb772.png)
I made my own character through a dot-taking program

![image](https://user-images.githubusercontent.com/49617190/205010935-dc34bc39-709a-4c7b-be81-4463f0a4e59c.png)
Through a dotting program, I made my own Asset-Department

### Sound Asset Source
I downloaded and used it at a place where it was available for free.
https://soundeffect-lab.info/sound/button/

---

## 📝 Code description
![image](https://user-images.githubusercontent.com/49617190/206884022-24b31927-a861-4273-935c-e635ca4aa163.png)
Code for player.cs.
Check if the character is stuck to the ground with the bowl is ground.
Press the space key with Input.GetKeyDown to jump the character as much as Force. Since it falls off the ground, make is ground false.
In OnCollisionEnter2D, the tag of the asset that the character touches is attached to the ground again if it is ground, so change isGround to true.

![image](https://user-images.githubusercontent.com/49617190/206884304-e9c24a2e-3bbd-4720-9938-580af6fb525e.png)
Code for wall.cs.
speed: variable that stores the speed value
Ground: Variables Containing Land Objects
wall: variables for obstacles
score: variable for score
score_cnt: variable to store rising scores
Speed += 0.1f*Time.deltaTime; makes it faster and faster over time.
Continue to increase your score with score_cnt+=1.
The transform function keeps creating obstacles and causes them to initialize positions
It gives an animation effect that keeps moving the ground asset below through the for statement.
Move the obstacle through the move function.

---

## 📝How to play - Screenshot

Download the latest version of v2.0.0 from the release of this repository, decompress the zip file, and run the BangUlEeDinogame.exe file for play.


<img src="https://user-images.githubusercontent.com/49617190/206883779-04e9690d-ee64-4251-8ada-f48edb506bdf.png" width="1000" height="700">

This is the game play screen On the far right side of the screen, the score of the game is made, and when you touch the cat character, it jumps up. Move forward to avoid randomly generated obstacles.
When the character jumps, a sound effect comes out, and when the character collides with an obstacle, the game ends with the sound effect.
The game progresses faster and faster.
The score of the game goes up faster and faster.

## 📝Review feedback
| Review, Feedback | Stars |
|-----------|------------|
| It's hard to play. It's fun | 5/5 |
| The design is unfortunate. Design to Designer | 4/5 |
| It's fun because the speed of the game is getting faster. | 4/5 |
| It would be nice to restart the game right away if there is a restart button. | 4/5 |

---

## 📝 Release
v1.0.0: This is the first version of the game.

v2.0.0: Current latest update for the game. I revised it reflecting the feedback and it is the update history.
- BangUlEeDinogame game re-production
- Awkward Asset Correction
- Modify to jump only when the character touches the floor
- Modify to speed up according to time
- Modify the speed at which the score increases faster according to time
- Change jump method from mouse click to space key
- Modified to play normally via exe file on your computer
- Other errors, awkwardness, bug fixes.
You can install this release to play the game.

Future Updates to be made
<img src="https://user-images.githubusercontent.com/49617190/206876072-e7efb84e-4974-4e5a-923f-2c27bdd61df5.png" width="400" height="400">
We will add future updates to make the game more difficult and lively by adding obstacles-bird to avoid cactus obstacles on the ground and new obstacles in the sky.
We are going to add the Restart button so that you can restart the game immediately within the game.

---


## 📝 Feeling
I made BangUlEeFlappybird game for the first time as an open-source project and made it more fun to make a game with Unity, so I wanted to make another game, so I made it. I plan to add restart function and other obstacles in the future, and I am determined to study game planning and design and submit my work to the indie game development competition by myself next year.

---
## 📝 References
Free easy game development lesson - development, launch and monetization in 3 hours - https://www.youtube.com/watch?v=EqoU1PodQQ4&t=6591s
3 minute dinosaur game production https://www.youtube.com/watch?v=bpAhWPQxMss
Wooden Wiki Dinosaur Game https://namu.wiki/w/Chrome/%EC%9D%B4%EC%8A4%A4%ED%84%B0%20%EC%97%90%EA%B7%B8



## 📝 License
Follow the MIT License. I've created a license.md file in my repository.

### 📝Game Demonstration Video ###
https://www.youtube.com/shorts/A_zOd4DcTT0

## ## 🖥️Developers
19101191 Kim Kyung-joon
