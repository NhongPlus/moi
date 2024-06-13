<template>
    <div>
    <header class="header">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="section-1">
                        <div class="inner-pic">
                            <router-link to="/"><img src="../assets/image/logohang.png" alt=""></router-link>
                        </div>
                        <div class="inner-find">
                            <input type="text" v-model="inputData" ref="childRef">
                            <button class="button" @click="search">Find</button>
                        </div>
                        <div class="inner-select">
                            <ul>
                                <li><router-link to="/">Home</router-link></li>
                                <li><router-link to="/about">About</router-link></li>
                                <li><router-link to="/cart">Cart</router-link></li>
                                <li><router-link to="/login">Log In</router-link></li>
                                <li><router-link to="/signup">Register</router-link></li>
                            </ul>
                        </div>
                        <div class="inner-bar">
                            <i class="fa-solid fa-bars"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    </div>
</template>


<script>

export default {
    data() {
        return {
            inputData: '',
        };
    },
    methods: {
        search() {
            const userInput = this.$refs.childRef.value;
            console.log(userInput);
        },
    }
}
</script>

<style scoped>
.alert {
  background-color: #f44336;
  color: white;
  text-align: center;
  padding: 10px;
  margin-top: 10px;
}
</style>