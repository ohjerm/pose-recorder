# pose-recorder
Application part of 3D pose-recording and replay using Unity ARFoundation
Be aware that without the pose detection ZMQ server this project is useless.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

 * [NetMQ](https://netmq.readthedocs.io/en/latest/#installation) is included in project but may need [ZMQ](https://zeromq.org/download/) installed.
 * ARFoundation 2.2 (enable preview packages in Unity package manager)
 * Unity3D 2019.2 (it will likely run on 2019.0 but has not been tested)
 * Other stuff I'm probably forgetting

### Installing

A step by step series of examples that tell you how to get a development env running

 1. Git clone or unzip the repo in your preferred Unity projects folder

```
cd /path/to/folder
git clone https://github.com/ChaiKnight/pose-recorder.git
```

 2. Open Unity Hub and Add new project, navigating to your folder and selecting it.

 3. Try and build the project on your phone. If you can press the record button, this part of the project is working.

## Deployment

Deploying this project currently requires a ZMQ server. More info to follow. 

## Authors

* **Oliver G. Hjermitslev** - [ChaiKnight](https://github.com/ChaiKnight)

See also the list of [contributors](https://github.com/ChaiKnight/pose-recorder/contributors) who participated in this project


