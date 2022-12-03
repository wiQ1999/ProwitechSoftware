<script>
    import UserForm from "$lib/components/users/UserForm.svelte";

    let user = {
        id: null,
        login: null,
        password: null,
        firstName: null,
        lastName: null,
        email: null,
        phoneNumber: null,
        roleId: null,
    };

    async function submitHandler() {
        console.log("TEST");
    }
</script>

<UserForm {user} on:submit={submitHandler} />
