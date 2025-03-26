# Inventory System

# 🛠️ Description
이 프로젝트는 Unity 엔진을 사용하여 게임에서 사용할 수 있는 인벤토리 시스템을 구현한 프로젝트입니다.

- **사용 기술**
  - 언어: C#
  - 엔진: Unity Engine
  - 데이터 관리: JSON

# 🎮 Core Features 
- UI 시스템 (FSM 기반)
- 아이템 관리 시스템
- JSON 기반 데이터 관리
- 캐릭터 시스템
- 장비 시스템

---
# 📁 Project Structure
## Scripts 폴더 구조

### Core Systems
- **StateMachine/**
  - UI 상태 관리 시스템
  - FSM 구현
  - 상태 전이 관리

- **Manager/**
  - 게임 전반적인 관리자 클래스들
  - 싱글톤 패턴 구현
  - 시스템 간 조율

### UI System
- **UI/**
  - UI 관련 컴포넌트
  - 인벤토리 UI
  - 상태 UI
  - 메인 메뉴 UI

### Item System
- **Item/**
  - 아이템 기본 클래스
  - 아이템 인스턴스 관리
  - 아이템 데이터 구조

- **Inventory/**
  - 인벤토리 시스템 구현
  - 슬롯 관리
  - 아이템 저장소

### Character System
- **Character/**
  - 캐릭터 관련 기능
  - 캐릭터 상태 관리
  - 캐릭터 속성

### Equipment System
- **Equipment/**
  - 장비 시스템 구현
  - 장비 타입 관리
  - 장비 효과 처리

### Utility
- **Utility/**
  - 유틸리티 클래스들
  - 헬퍼 함수
  - 공통 기능

### Editor
- **Editor/**
  - Unity 에디터 확장
  - 커스텀 에디터 도구
  - 디버깅 도구

### User
- **User/**
  - 사용자 관련 기능
  - 사용자 데이터 관리
  - 사용자 설정

---
# 🧚‍♀️ UI System
## UI 시스템 구조
### FSM (Finite State Machine)
UI 상태 관리를 위해 FSM을 구현했습니다. 각 상태는 스택을 통해 이전 상태로 돌아갈 수 있습니다.

- **상태 목록**
  - MainMenu: 메인 메뉴 상태
  - Status: 캐릭터 상태 창
  - Inventory: 인벤토리 창

- **특징**
  - 스택 기반 상태 관리
  - 이전 상태로의 복귀 가능
  - 모듈화된 UI 구조

---
# 🐯 Item System
## 아이템 시스템 구조
### 3-Tier 아이템 구조

1. **ItemInfo (정적 데이터)**
   - JSON 파일에서 로드되는 기본 아이템 정보
   - ID, 이름, 설명, 아이콘 경로 등 기본 속성
   - 읽기 전용 데이터

2. **ItemObject (동적 데이터)**
   - ItemInfo를 기반으로 한 실제 게임 내 아이템
   - 현재 수량, 내구도 등 동적 속성
   - 게임 월드에 존재하는 아이템 표현

3. **ItemInstance (사용자 소유)**
   - ItemObject와 사용자 정보를 포함
   - 인벤토리에서 관리되는 아이템
   - 사용자에게 지급되는 형태

### 아이템 타입
- **일반 아이템**
  - 스택 가능
  - 수량 관리
  - 기본 속성

- **장비 아이템**
  - 스택 불가능
  - 장비 특수 속성 (ATK, DEF, HP, CRITICAL)
  - 장비 타입 구분

### 데이터 관리
- JSON 파일을 통한 아이템 데이터 관리
- Resources 폴더에서 동적 로드
- Dictionary를 통한 빠른 아이템 검색

---
