<template>
    <div class="fun-api-container">
      <!-- picture -->
      <div class="fun-image-box">
        <img src="@/assets/api-demo.png" alt="API Illustration" class="fun-hero-image">
        
        <!-- cute button -->
        <button class="fun-api-button" @click="loadData">
          <span class="button-icon">📡</span>
          Connect to API
        </button>
      </div>
  
      <!-- result -->
      <div class="fun-results" v-if="items.length > 0">
        <div class="result-header">
          <span class="result-icon">🎉</span>
          <h3>API Response Success!</h3>
        </div>
        <div class="result-content">
          <div v-for="(item, index) in items" :key="index" class="result-item">
            <span class="item-icon">✨</span>
            <span>{{ item.name || item.title || JSON.stringify(item) }}</span>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import axios from 'axios'
  
  export default {
    data() {
      return {
        items: []
      }
    },
    methods: {
      async loadData() {
        try {
          const response = await axios.get('http://localhost:5175/api/todo')
          this.items = response.data
        } catch (error) {
          this.items = [{ error: "Oops! Connection failed ❌" }]
        }
      }
    }
  }
  </script>
  
  <style scoped>
  
  .fun-api-container {
    max-width: 900px;
    margin: 40px auto;
    font-family: 'Arial Rounded MT Bold', sans-serif;
  }
  
  
  .fun-image-box {
    position: relative;
    margin: 0 auto 30px;
    width: 230%;
    border-radius: 25px;
    overflow: hidden;
    box-shadow: 0 8px 20px rgba(233, 178, 175, 0.3);
  }
  
  .fun-hero-image {
    width: 100%;
    height: 450px;
    object-fit: cover;
    display: block;
  }
  
  
  .fun-api-button {
    position: absolute;
    bottom: 40px;
    left: 50%;
    transform: translateX(-50%);
    background: #FF9AA2;
    color: white;
    border: none;
    padding: 16px 32px;
    border-radius: 50px;
    font-size: 1.2rem;
    font-weight: bold;
    cursor: pointer;
    display: flex;
    align-items: center;
    gap: 10px;
    box-shadow: 0 4px 15px rgba(255, 154, 162, 0.5);
    transition: all 0.3s cubic-bezier(0.175, 0.885, 0.32, 1.275);
  }
  
  .fun-api-button:hover {
    background: #FF7B8B;
    transform: translateX(-50%) scale(1.05);
    box-shadow: 0 6px 20px rgba(255, 123, 139, 0.6);
  }
  
  .button-icon {
    font-size: 1.4rem;
  }
  
  
  .fun-results {
    background: #FFF5F5;
    border-radius: 16px;
    padding: 25px;
    margin-top: 20px;
    border: 2px dashed #FFB7B7;
    align-items: center;
  }
  
  .result-header {
    display: flex;
    align-items: center;
    gap: 10px;
    margin-bottom: 15px;
    color: #FF6B88;
  }
  
  .result-header h3 {
    margin: 0;
    font-size: 1.3rem;
  }
  
  .result-icon {
    font-size: 1.8rem;
  }
  
  .result-content {
    background: white;
    border-radius: 12px;
    padding: 15px;
  }
  
  .result-item {
    padding: 10px;
    border-bottom: 1px solid #FFE0E0;
    display: flex;
    align-items: center;
    gap: 8px;
  }
  
  .item-icon {
    color: #FF9AA2;
  }
  </style>