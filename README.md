# 🧠 AI Image Tagging App (ML.NET)

A simple C# application that automatically organizes images into folders based on their content using AI.

👉 Example:
`IMG_123.jpg → Dog/IMG_123.jpg`

This project uses **ML.NET** to run machine learning locally—no cloud APIs or paid services required.

---

## 🚀 Features

* 📂 Select a folder of images
* 🤖 AI analyzes image content
* 🏷 Automatically creates folders (Dog, Car, Mountain, etc.)
* 📁 Moves images into categorized folders
* 💻 Runs completely offline using ML.NET

---

## 🛠 Tech Stack

* C#
* .NET
* ML.NET
* Visual Studio 2022

---

## 📦 Project Structure

```
AIImageTagging/
│
├── TrainingData/
│   ├── Dog/
│   ├── Car/
│   ├── Mountain/
│
├── Model/
│   └── ImageClassifier.mbconfig
│
├── Program.cs
└── README.md
```

---

## 🧩 Phase 1: Setup & Installation

### 1️⃣ Install Visual Studio

Download **Visual Studio 2022 (Community Edition)**

During installation, select:

* ✅ .NET Desktop Development
* ✅ ML.NET Model Builder (under Individual Components)

---

### 2️⃣ Prepare Training Data

Create a folder:

```
TrainingData/
```

Inside it, create subfolders for each category:

```
TrainingData/
├── Dog/
├── Car/
├── Mountain/
```

📌 Add **20–50 images per category**
👉 This is what your AI model will learn from.

---

## 🏗 Phase 2: Create the Project

1. Open Visual Studio
2. Click **Create New Project**
3. Select:

   ```
   Console App (C#)
   ```
4. Name your project:

   ```
   SmartPhotoOrganizer
   ```

---

### ➕ Add ML Model

* Right-click project → **Add → Machine Learning Model**
* Name it:

  ```
  ImageClassifier.mbconfig
  ```

---

## 🧠 Phase 3: Train the AI Model

### Step 1: Open Model Builder

Follow the wizard:

---

### 🔹 Scenario

Select:

```
Image Classification
```

---

### 🔹 Environment

Choose:

* CPU (default)
* OR GPU (if you have NVIDIA GPU)

---

### 🔹 Data

* Select your `TrainingData` folder

---

### 🔹 Train

* Click **Start Training**
* ⏱ Takes ~2–5 minutes

---

### 🔹 Evaluate

* Test with random images
* Check prediction accuracy

---

### 🔹 Consume

* Click:

```
Add to Solution
```

👉 This generates:

* Model files
* Prediction classes
* Helper code

---

## 💻 Phase 4: Implement Image Organizer

Edit `Program.cs` to:

1. Scan input folder
2. Use ML model to predict image label
3. Create folder if not exists
4. Move image into predicted category

---

### 🔹 Sample Logic

```csharp
// Pseudo flow
foreach (var image in images)
{
    var prediction = Predict(image);

    var folderPath = Path.Combine(basePath, prediction.Label);

    if (!Directory.Exists(folderPath))
        Directory.CreateDirectory(folderPath);

    File.Move(image, Path.Combine(folderPath, Path.GetFileName(image)));
}
```

---

## ▶️ Phase 5: Run the Application

* Press **F5** in Visual Studio
* Console will start processing images

### ✅ Output Example:

```
Processing IMG_001.jpg → Dog
Processing IMG_002.jpg → Car
```

---

## 🎯 Result

Your images will be automatically organized like:

```
Output/
├── Dog/
├── Car/
├── Mountain/
```

---

## ⚠️ Tips for Better Accuracy

* Use clear, high-quality images
* Keep categories distinct
* Add more training data (50+ images improves accuracy)

---


## 📚 Learning Outcomes

* ML.NET basics
* Image classification
* Model training & evaluation
* Real-world AI integration in C#

---

## ⭐ Summary

This project demonstrates how to:

✔ Build AI apps using C#
✔ Train models locally using ML.NET
✔ Automate real-world tasks

---
<video controls src="AI-Image-Tagging.mp4" title="Title"></video>