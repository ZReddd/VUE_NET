<script setup>
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <!-- Main header with white background -->
  <header class="guestpix-header">
    <div class="header-container">
      <!-- Left logo section -->
      <div class="logo-section">
        <RouterLink to="/" class="logo-link">
          <img src="@/assets/logo.svg" alt="Logo" class="logo">
          <span class="brand-name">TaskPix</span>
        </RouterLink>
      </div>
      
      <!-- Center navigation -->
      <nav class="main-nav">
        <span class="nav-item">Events</span>
        <span class="nav-item">How It Works</span>
        <span class="nav-item">Pricing</span>
        <span class="nav-item">About Us</span>
        <span class="nav-item">Help Center</span>
        
        <!-- Functional navigation links -->
        <RouterLink to="/" class="nav-item" active-class="active">Home</RouterLink>
        <RouterLink to="/about" class="nav-item" active-class="active">About</RouterLink>
        <RouterLink to="/API" class="nav-item" active-class="active">API</RouterLink>
      </nav>
      
      <!-- Right action button -->
      <div class="action-section">
        <button class="get-started-btn">Get Started</button>
      </div>
    </div>
  </header>

  <!-- Main content area -->
  <main class="main-content">
    <RouterView />
  </main>
</template>

<style scoped>
/* Header styles */
.guestpix-header {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  background: white; 
  box-shadow: 0 2px 10px rgba(0,0,0,0.1);
  z-index: 1000;
  height: 70px;
  display: flex;
  align-items: center;
}

.brand-name {
  font-size: 1.5rem;
  font-weight: 600;
  color: #434faa !important;
}

.nav-item {
  font-size: 1rem;
  color: #e58783 !important;
  padding: 5px 0;
  position: relative;
  text-decoration: none;
}

.nav-item.active {
  color: #101014 !important;
  font-weight: 500;
}

/* Get Started button */
.get-started-btn {
  background: white !important;
  color: #e58783 !important;
  border: 2px solid #e58783 !important; 
  padding: 8px 20px;
  border-radius: 6px;
  font-weight: 500;
  font-size: 1rem;
  cursor: pointer;
  transition: all 0.3s;
  height: 40px; 
  display: inline-flex;
  align-items: center;
  justify-content: center;
}

.get-started-btn:hover {
  background: #f8f0f0 !important; 
  color: #d47a77 !important;
  border-color: #d47a77 !important;
}


.header-container {
  width: 100%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 20px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.logo-section {
  display: flex;
  align-items: center;
}

.logo-link {
  display: flex;
  align-items: center;
  gap: 10px;
  text-decoration: none;
}

.logo {
  height: 36px;
  width: auto;
}

.main-nav {
  display: flex;
  gap: 25px;
}

.nav-item.active::after {
  content: '';
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  height: 2px;
  background: currentColor;
}

.main-nav span.nav-item {
  cursor: default;
}

.main-content {
  margin-top: 70px;
  padding: 20px;
  max-width: 1200px;
  margin-left: auto;
  margin-right: auto;
}
</style>