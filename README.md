# SAP Business One SDK 示例项目

## 项目概述

本项目是一个基于SAP Business One SDK的示例项目，主要用于展示如何使用C#与SAP Business One系统进行交互。项目包含了一些示例代码和相关配置说明，帮助开发者快速上手SAP Business One的开发。

## 项目结构

### 代码文件
- **DIExercise.cs**：这是一个继承自`System.Windows.Forms.Form`的类，可能用于创建与SAP Business One相关的Windows窗体应用程序。
- **HelloWorld.cs**：包含了关于使用SAP Business One SDK的示例代码，同时有详细的注释说明使用前的准备工作。

### 文本文件
- **Readme.txt**（部分为XML格式的`xliff`文件）：包含了一些元数据和翻译单元信息，可能用于国际化和本地化工作。

## 环境配置

在开始使用本项目的示例代码之前，需要进行以下环境配置：

### 添加引用
1. **SAP Business One UI API**：
    - 打开项目的“引用”设置（Project -> References）。
    - 勾选“SAP Business One UI API 2007”复选框。

2. **SAP Business One Objects Bridge VERSION 2007**：
    - 同样在项目的“引用”设置（Project -> References）中。
    - 勾选“SAP Business One Objects Bridge VERSION 2007”复选框。

### 配置连接字符串
- 打开项目的属性设置（Project -> Properties）。
- 选择“Make”选项卡。
- 在“Command Line Arguments”字段中插入以下开发连接字符串：
