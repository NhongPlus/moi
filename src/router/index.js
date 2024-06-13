import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import SanPham from '../views/SanPham.vue'
import DangNhap from '../views/DangNhap.vue'
import DangKi from '../views/DangKi.vue'
import IntroSpham from '../views/IntroSpham.vue'
// import ProductItem from '../components/ProductItem.vue'
const routes = [
  {
    path: '/',
    component: HomeView
  },
  {
    path: '/cart',
    component: SanPham
  },
  {
    path: '/intro/:id',
    name: 'intro',
    component: IntroSpham,
  },
  
  {
    path: '/login',
    component: DangNhap
  },
  {
    path: '/signup',
    component: DangKi
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
