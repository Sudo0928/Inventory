# Inventory

# 🛠️ Description
프로젝트 소개
해당 프로젝트는 게임에서 사용하는 Inventory를 만드는 프로젝트 입니다.

- **사용 기술** <br>
-언어 : C#<br>
-엔진 : Unity Engine <br>
<br>

# 🎮 Core Features 
- UI 전환
- Item 관리

---
# 🧚‍♀️ UI System
## UI 시스템 <br>
### FSM (유한 상태 머신)<br>

아주 간단한 UI의 경우 보여지는 창이 하나라는 가정하에 FSM을 사용하여 만들어 보았습니다.

- MainMenu
- Status
- Inventory

  또한, 이전 상태로 돌아가기 위해서 Stack을 통해 PrevState를 추가하여 이전 상태로 돌아갈 수 있도록 구성 하였습니다.

---
# 🐯 Item
## Item 관리 <br>
### ItemObject, ItemInstance<br>

1. 읽기 전용인 기획 테이블에서 ItemInfo가 있다.
2. 현재 내구도, 현재 개수 와 같은 동적 데이터와 정적 데이터인 ItemInfo를 가지고 있는 ItemObject가 있다.
3. ItemObject와 해당 아이템을 가지고 있는 User 정보를 가지고 있는 ItemInstance가 있다.

Item을 위 3가지로 구분하여 사용 하였습니다.

User에게 아이템이 지급이 될때는 ItemInstance형태로 지급이 됩니다.
Item이 땅에 버려져 있다면 ItemObject형태로 존재합니다.
